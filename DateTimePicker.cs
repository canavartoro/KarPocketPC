
using System;
using System.Windows.Forms;
using System.Drawing;


namespace TOLGA
{
	#region DateTimePickerFormat enumeration

	/// <summary>
	/// Specifies the date and time format the DateTimePicker control displays.
	/// </summary>
	public enum DateTimePickerFormat
	{
		Long,
		Short
	}

	#endregion

	#region DateTimePicker class

	/// <summary>
	/// Manged DateTimePicker control. User can select a day from popup calendar.
	/// </summary>
	public class DateTimePicker : Control
	{
		class Const
		{
			// size of the drop arrow on far right
			public static Size DropArrowSize = new Size(7,4);
		}
		
		// offscreen bitmap
		Bitmap m_bmp;
		Graphics m_graphics;

		// gdi objects
		SolidBrush m_brushFore;
		SolidBrush m_brushDisabled;
		SolidBrush m_brushFrame;
		Pen m_penFrame;
		
		// down arrow coordinates
		Point[] m_arrowPoints = new Point[3];
		
		// day picker, displays popup month calendar
		DayPickerPopup m_dayPicker = new DayPickerPopup();
		
		// date format, short or long
		DateTimePickerFormat m_format = DateTimePickerFormat.Long;

		// exposed events
		public event EventHandler ValueChanged;
		public event EventHandler CloseUp;
		public event EventHandler DropDown;
		
		
		// properties


		/// <summary>
		/// Gets the maximum date value.
		/// </summary>
		public static DateTime MaxDateTime
		{
			get { return DateTime.MaxValue; }
		}

		/// <summary>
		/// Gets the minimum date value.
		/// </summary>
		public static DateTime MinDateTime
		{
			get { return DateTime.MinValue; }
		}

		/// <summary>
		/// Gets or sets the format of the date displayed in the control.
		/// </summary>
		public DateTimePickerFormat Format
		{
			get { return m_format; }
			set 
			{
				// update format and repaint
				m_format = value;
				Invalidate();
			}
		}

		/// <summary>
		/// Gets or sets the date value assigned to the control.
		/// </summary>
		public DateTime Value
		{
			// setting the picker value raises the ValueChanged
			// event which causes the control to repaint
			get { return m_dayPicker.Value; }
			set { m_dayPicker.Value = value; }
		}

		/// <summary>
		/// Gets or sets the text associated with this control. Throws a
		/// FormatException if the specified text is not a valid date.
		/// </summary>
		public override String Text
		{
			get 
			{ 
				// return date as string in the correct format
				return (m_format == DateTimePickerFormat.Short) ?
					this.Value.ToShortDateString() :
					this.Value.ToLongDateString();
			}
			set 
			{ 
				// update the datetime value
				this.Value = DateTime.Parse(value);
			}
		}
		
		
		/// <summary>
		/// Constructor. Initializes a new instance of the DateTimePicker class.
		/// </summary>
		public DateTimePicker()
		{
			// hookup day picker events
			m_dayPicker.CloseUp += new EventHandler(OnDayPickerCloseUp);
			m_dayPicker.ValueChanged += new EventHandler(OnDayPickerValueChanged);
		}


		// drawing methods

		
		protected override void OnPaint(PaintEventArgs e) 
		{
			// draw to memory bitmap
			CreateMemoryBitmap();
			CreateGdiObjects();

			// init background
			m_graphics.Clear(this.BackColor);

			// label 
			Size size = m_graphics.MeasureString(this.Text, this.Font).ToSize();
			m_graphics.DrawString(this.Text, this.Font, 
				this.Enabled ? m_brushFore : m_brushDisabled, 
				4, (this.Height - size.Height)/2);

			// drop arrow
			m_graphics.FillPolygon(m_brushFrame, m_arrowPoints);

			// frame around control
			m_graphics.DrawRectangle(m_penFrame, 0, 0, this.Width-1, this.Height-1);
			
			// blit memory bitmap to screen
			e.Graphics.DrawImage(m_bmp, 0, 0);
		}

		protected override void OnPaintBackground(PaintEventArgs e) 
		{
			// don't pass to base since we paint everything, avoid flashing
		}


		// events


		/// <summary>
		/// Show or hide the day picker popup control. Determine the 
		/// best location to display the day picker.
		/// </summary>
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			
			// add day picker control to the toplevel window
			// this allows the control to display on top of 
			// tabs and other controls
			if (m_dayPicker.Parent == null)
				this.TopLevelControl.Controls.Add(m_dayPicker);

			// intelligently calculate where the day picker should be displayed, 
			// try to display below the label control, display above the control 
			// if there is not enough room
			Point pos = new Point(this.Left, this.Bottom+1);

			// map points to top level window			
			Point parentPos = this.Parent.PointToScreen(this.Parent.Location);
			Point topParentPos = this.TopLevelControl.PointToScreen(this.Parent.Location);
			pos.Offset(parentPos.X - topParentPos.X, parentPos.Y - topParentPos.Y);

			// see if there is enough room to display day picker below label
			if ((pos.Y + m_dayPicker.Size.Height) > this.TopLevelControl.ClientRectangle.Height)
			{
				// there is not enough room, try displaying above the label
				pos.Y -= (this.Height + m_dayPicker.Size.Height + 2);
				if (pos.Y < 0)
				{
					// there was not enough room, display at bottom of screen
					pos.Y = (this.TopLevelControl.ClientRectangle.Height - 
						m_dayPicker.Size.Height);	
				}
			}
			
			// try displaying aligned with the label control
			if ((pos.X + m_dayPicker.Size.Width) > this.TopLevelControl.ClientRectangle.Width)
				pos.X = (this.TopLevelControl.ClientRectangle.Width - m_dayPicker.Size.Width);	

			// display or hide the day picker control			
			m_dayPicker.Display(
				!m_dayPicker.Visible, pos.X, pos.Y, 
				this.BackColor, this.ForeColor);
			
			// raise the DropDown or CloseUp event
			if (m_dayPicker.Visible && this.DropDown != null)
				this.DropDown(this, EventArgs.Empty);
				
			if (!m_dayPicker.Visible && this.CloseUp != null)
				this.CloseUp(this, EventArgs.Empty);
		}
				
		/// <summary>
		/// CloseUp event from the day picker control
		/// </summary>
		private void OnDayPickerCloseUp(object sender, System.EventArgs e)
		{
			// pass to our container
			if (this.CloseUp != null)
				this.CloseUp(this, EventArgs.Empty);
		}

		/// <summary>
		/// ValueChanged event from the day picker control
		/// </summary>
		private void OnDayPickerValueChanged(object sender, System.EventArgs e)
		{
			// repaint to display the new value
			Invalidate();
			
			// pass along to our container
			if (this.ValueChanged != null)
				this.ValueChanged(this, e);
		}


		// helper methods
		
		
		/// <summary>
		/// Create offsceeen bitmap. This bitmap is used for double-buffering
		/// to prevent flashing.
		/// </summary>
		private void CreateMemoryBitmap()
		{
			if (m_bmp == null || m_bmp.Width != this.Width || m_bmp.Height != this.Height)
			{
				// memory bitmap
				m_bmp = new Bitmap(this.Width, this.Height);
				m_graphics = Graphics.FromImage(m_bmp);	

				// calculate down arrow points				
				m_arrowPoints[0].X = this.Width - Const.DropArrowSize.Width - 4;
				m_arrowPoints[0].Y = (this.Height - Const.DropArrowSize.Height+1) / 2;
				m_arrowPoints[1].X = m_arrowPoints[0].X + Const.DropArrowSize.Width;
				m_arrowPoints[1].Y = m_arrowPoints[0].Y;
				m_arrowPoints[2].X = m_arrowPoints[0].X + (Const.DropArrowSize.Width/2);
				m_arrowPoints[2].Y = m_arrowPoints[0].Y + Const.DropArrowSize.Height;
			}
		}
		
		/// <summary>
		/// Create GDI objects required to paint the control.
		/// </summary>
		private void CreateGdiObjects()
		{
			// window frame brush
			if (m_brushFrame == null)
				m_brushFrame = new SolidBrush(SystemColors.WindowFrame);
				
			// window frame pen
			if (m_penFrame == null)
				m_penFrame = new Pen(SystemColors.WindowFrame);

			// fore color brush, the .Net CF does not support OnForeColorChanged, 
			// so we detect if the forecolor changed here
			if (m_brushFore == null || m_brushFore.Color != this.ForeColor)				
				m_brushFore = new SolidBrush(this.ForeColor);
				
			// disabled brush
			if (m_brushDisabled == null)
				m_brushDisabled = new SolidBrush(SystemColors.GrayText);
		}
	}
	
	#endregion
	
	#region DayPickerPopup class

	/// <summary>
	/// Displays a calendar that allows user to select a new date.
	/// Displays box around today and user can hover over dates.
	/// Allows quick access to month with month context menu and year
	/// with numeric updown control.
	/// </summary>
	class DayPickerPopup : Control
	{
		class Const
		{
			// font for caption, days of week and days
			public const string FontName = "Arial";
			public const int FontSize = 9;
			
			// location and size of different elements in calendar
			public const int ControlWidth = 164;
			public const int CaptionHeight = 28;
			public static Point DaysGrid = new Point(6, 43);
			public static Size DaysCell = new Size(23, 14);
			public const int NumCols = 7;
			public const int NumRows = 6;
			
			// arrow buttons
			public static Size ArrowButtonOffset = new Size(6, 6);
			public static Size ArrowButtonSize = new Size(20, 15);
			public static Size ArrowPointsOffset = new Size(13, 9);
			public static Size ArrowPointsSize = new Size(5, 10);
			
			// bottom today label
			public static Point BottomLabelsPos = new Point(6, 135);
			public const int BottomLabelHeight = 12;
		}

		// exposed events
		public event EventHandler CloseUp;
		public event EventHandler ValueChanged;
		
		// memory bitmap to prevent flashing
		Bitmap m_bmp;
		Graphics m_graphics;

		// gdi objects
		Font m_font;

		// days
		SolidBrush m_brushCur;
		SolidBrush m_brushOther;
		SolidBrush m_brushSelBack;
		SolidBrush m_brushSelText;
		Pen m_penHoverBox;

		// caption
		Font m_fontCaption;
		SolidBrush m_brushCaptionBack;
		SolidBrush m_brushCaptionText;
		
		// general
		SolidBrush m_brushBack;
		Pen m_penBack;
		SolidBrush m_brushFrame;
		Pen m_penFrame;		
		
		// store dates; today, current selection, current hover
		// and the first date in the calendar		
		DateTime m_today = DateTime.Today;
		DateTime m_curSel = DateTime.Today;
		DateTime m_hoverSel = DateTime.Today;
		DateTime m_firstDate;

		// if capturing mouse events (hovering over days)		
		bool m_captureMouse=false;

		// cache calendar for better performance, each DateTime
		// structure if only 8 bytes
		int m_curMonth = -1;
		int m_curYear = -1;
		DateTime[] m_days = new DateTime[42];

		// caption controls; user can click on month and year 
		// in caption to quickly change values
		ContextMenu m_monthMenu;
		NumericUpDown m_yearUpDown;

		// hit testing
		Rectangle m_rcLeftButton = Rectangle.Empty;
		Rectangle m_rcRightButton = Rectangle.Empty;
		Rectangle m_rcMonth = Rectangle.Empty;
		Rectangle m_rcYear = Rectangle.Empty;
		
		// arrow button coordinates
		Point[] m_leftArrowPoints = new Point[3];
		Point[] m_rightArrowPoints = new Point[3];


		// properties
		
		
		/// <summary>
		/// Selected date.
		/// </summary>
		public DateTime Value
		{
			get { return m_curSel; }
			set 
			{ 
				if (value != m_curSel)
					UpdateCurSel(value); 
			}
		}
		
		
		/// <summary>
		/// Constructor. 
		/// </summary>
		public DayPickerPopup()
		{
			// init controls that popup when click on the
			// month or year in the caption
			InitMonthContextMenu();
			InitYearUpDown();
					
			// init display properties
			this.Visible = false;
			this.Location = new Point(0, 0);
			this.Size = new Size(Const.ControlWidth,
				Const.BottomLabelsPos.Y + Const.BottomLabelHeight + 5);
		}


		// public methods


		/// <summary>
		/// Show or hide the calendar.
		/// </summary>
		public void Display(bool visible, int x, int y, Color backColor, Color foreColor)
		{
			if (visible)
			{
				// initialize properties if being displayed
				m_captureMouse = false;
				m_yearUpDown.Hide();
				
				this.BackColor = backColor;
				this.ForeColor = foreColor;
				this.Left = x;
				this.Top = y;
				this.BringToFront();
				this.Focus();
				
				// default to hovering over the current selection 
				m_hoverSel = m_curSel;
			}

			// hide or show the calendar
			this.Visible = visible;
		}


		// drawing methods


		protected override void OnPaint(PaintEventArgs e) 
		{
			// draw to memory bitmap
			CreateMemoryBitmap();
			CreateGdiObjects();

			// calculate the fist date in the days grid, this is used
			// to draw the previous month days, the current month days,
			// and any days in the next month
			CalculateFirstDate();

			// init the background
			m_graphics.Clear(this.BackColor);

			// draw elements of the calendar
			// the caption and days of week
			DrawCaption(m_graphics);
			DrawDaysOfWeek(m_graphics);
			
			// the days grid and different selections
			DrawDays(m_graphics);
			DrawCurSelection(m_graphics);
			DrawHoverSelection(m_graphics, m_hoverSel, true);
			DrawTodaySelection(m_graphics);

			// the today label at the bottom
			DrawBottomLabels(m_graphics);

			// frame around the control			
			m_graphics.DrawRectangle(m_penFrame, 0, 0,
				this.Width-1, this.Height-1);
			
			// blit memory bitmap to screen
			e.Graphics.DrawImage(m_bmp, 0, 0);
		}

		protected override void OnPaintBackground(PaintEventArgs e) 
		{
			// don't pass to base since we paint everything, avoid flashing
		}
		
		/// <summary>
		/// Draw caption; current month, current year, 
		/// left and right arrow buttons.
		/// </summary>
		private void DrawCaption(Graphics g)
		{
			// back area
			g.FillRectangle(m_brushCaptionBack, 0, 0, this.Width, Const.CaptionHeight);
			
			// draw the caption centered in the area
			string text = m_curSel.ToString("MMMM yyyy");
			Size totalSize = g.MeasureString(text, m_fontCaption).ToSize();
			int x = (this.Width - totalSize.Width) / 2;
			int y = (Const.CaptionHeight - totalSize.Height) / 2;
			g.DrawString(text, m_fontCaption, m_brushCaptionText, x, y);

			// calculate the bounding rectangle for each element (the
			// month and year) so we can detect if the user clicked on
			// either element later
			
			// calculate the month bounding rectangle
			text = m_curSel.ToString("MMMM");
			Size size = g.MeasureString(text, m_fontCaption).ToSize();
			m_rcMonth.X = x;
			m_rcMonth.Y = y;
			m_rcMonth.Width = size.Width;
			m_rcMonth.Height = size.Height;
			
			// calculate the year bounding rectangle
			text = m_curSel.ToString("yyyy");
			size = g.MeasureString(text, m_fontCaption).ToSize();
			m_rcYear.X = x + totalSize.Width - size.Width;
			m_rcYear.Y = y;
			m_rcYear.Width = size.Width;
			m_rcYear.Height = size.Height;
			
			// draw the left arrow button
			g.FillRectangle(m_brushBack, m_rcLeftButton);
			g.DrawRectangle(m_penFrame, m_rcLeftButton);
			g.FillPolygon(m_brushFrame, m_leftArrowPoints);
				
			// draw the right arrow button
			g.FillRectangle(m_brushBack, m_rcRightButton);
			g.DrawRectangle(m_penFrame, m_rcRightButton);
			g.FillPolygon(m_brushFrame, m_rightArrowPoints);
		}

		/// <summary>
		/// Draw days of week header.
		/// </summary>
		private void DrawDaysOfWeek(Graphics g)
		{
			const string dow = "SMTWTFS";
			
			// calculate where to draw days of week
			Point pos = new Point(Const.DaysGrid.X+3, Const.CaptionHeight);
			
			// go through and draw each character
			foreach (char c in dow)
			{
				g.DrawString(c.ToString(), m_fontCaption, m_brushCaptionBack, pos.X, pos.Y);
				pos.X += Const.DaysCell.Width;
			}
			
			// separator line
			g.DrawLine(m_penFrame, Const.DaysGrid.X, Const.DaysGrid.Y-1,
				this.Width - Const.DaysGrid.X, Const.DaysGrid.Y-1);
		}

		/// <summary>
		/// Draw days in the grid. Recalculate and cache days if the 
		/// month or year changed.
		/// </summary>
		private void DrawDays(Graphics g)
		{
			// see if need to calculate new set of days
			if (m_curSel.Month != m_curMonth || m_curSel.Year != m_curYear)
			{
				// the month of year changed, calculate and cache new set of days
				CalculateDays();
				m_curMonth = m_curSel.Month;
				m_curYear = m_curSel.Year;
			}

			// starting point of grid
			Point pos = Const.DaysGrid;
			
			// any extra pixels (used for single digit numbers)
			int extra;				
			
			// loop through and draw each day in the grid			
			for (int y=0; y < Const.NumRows; y++)
			{
				for (int x=0; x < Const.NumCols; x++)
				{
					// get the date from the cache
					DateTime display = m_days[(y*7)+x];
					
					// see if requires extra pixels (single digit day)
					extra = (display.Day < 10) ? 4 : 0;
					
					g.DrawString(display.Day.ToString(), m_font, 
						(display.Month == m_curMonth) ? m_brushCur : m_brushOther, 
						pos.X + extra, pos.Y);

					// update position within the grid						
					pos.X += Const.DaysCell.Width;
				}
				
				// update position within the grid
				pos.X = Const.DaysGrid.X;
				pos.Y += Const.DaysCell.Height + 1;
			}
		}
		
		/// <summary>
		/// Draw the specified day.
		/// </summary>
		private void DrawDay(Graphics g, DateTime day, bool selected)
		{
			// get the position of this cell in the grid
			int index = GetDayIndex(day);
			Point pos = GetDayCellPosition(index);

			// cell background
			g.FillRectangle(selected ? m_brushSelBack : m_brushBack, 
				pos.X - 5, pos.Y, Const.DaysCell.Width, Const.DaysCell.Height);
			
			// extra space if single digit
			if (day.Day < 10)
				pos.X += 4;
				
			// the day				
			g.DrawString(day.Day.ToString(), m_font, 
				selected ? m_brushSelText : m_brushCur, 
				pos.X, pos.Y);
		}
		
		/// <summary>
		/// Draw the currently selected day.
		/// </summary>
		private void DrawCurSelection(Graphics g)
		{
			// calculate the coordinates of the current cell
			int index = GetDayIndex(m_curSel);
			Point pos = GetDayCellPosition(index);

			// background
			m_graphics.FillRectangle(m_brushSelBack, pos.X - 5, pos.Y, 
				Const.DaysCell.Width, Const.DaysCell.Height);
			
			// extra space for single digit days
			if (m_curSel.Day < 10)
				pos.X += 4;
				
			// the day
			m_graphics.DrawString(m_curSel.Day.ToString(), 
				m_font, m_brushSelText, pos.X, pos.Y);
		}

		/// <summary>
		/// Draws of erases the hover selection box.
		/// </summary>
		private void DrawHoverSelection(Graphics g, DateTime date, bool draw)
		{
			// see if hovering over a cell, return right away
			// if outside of the grid area
			int index = GetDayIndex(date);
			if (index < 0 || index >= m_days.Length)
				return;

			// get the coordinates of cell
			Point pos = GetDayCellPosition(index);
			
			// draw or erase the hover selection
			g.DrawRectangle(draw ? m_penHoverBox : m_penBack, 
				pos.X - 5, pos.Y, Const.DaysCell.Width, Const.DaysCell.Height);
		}

		/// <summary>
		/// Draw box around today on grid.
		/// </summary>
		private void DrawTodaySelection(Graphics g)
		{
			// see if today is visible in the current grid
			int index = GetDayIndex(m_today);
			if (index < 0 || index >= m_days.Length)
				return;
			
			// only draw on current month	
			if (m_today.Month != m_curSel.Month)
				return;

			// today is visible, draw box around cell
			Point pos = GetDayCellPosition(index);
			g.DrawRectangle(m_penFrame, pos.X-5, pos.Y, 
				Const.DaysCell.Width, Const.DaysCell.Height);

			g.DrawRectangle(m_penFrame, pos.X-4, pos.Y+1, 
				Const.DaysCell.Width-2, Const.DaysCell.Height-2);
		}

		/// <summary>
		/// Draw the today label at bottom of calendar.
		/// </summary>
		private void DrawBottomLabels(Graphics g)
		{
			// draw today string, don't store bounding rectangle since 
			// hit testing is the entire width of the calendar
			string text = string.Format("Today: {0}", m_today.ToShortDateString());
			g.DrawString(text, this.m_fontCaption, this.m_brushCur,
				Const.BottomLabelsPos.X, Const.BottomLabelsPos.Y);
		}


		// events


		/// <summary>
		/// Determine what area was taped (clicked) and take the appropriate 
		/// action. If no items were taped, see if should start tracking mouse.
		/// </summary>
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
		
			// see if should hide the year updown control
			if (m_yearUpDown.Visible)
			{
				if (!m_yearUpDown.Bounds.Contains(e.X, e.Y))
				{
					// user clicked outside of updown control,
					// update grid with the new year specified 
					// in the updown control
					OnYearUpDownValueChanged(null, EventArgs.Empty);
					m_yearUpDown.Hide();
					this.Focus();
				}
			}
		
			// left arrow button
			if (m_rcLeftButton.Contains(e.X, e.Y))
			{
				// display previous month
				UpdateCurSel(m_curSel.AddMonths(-1));
				return;
			}

			// right arrow button
			if (m_rcRightButton.Contains(e.X, e.Y))
			{
				// display the next month
				UpdateCurSel(m_curSel.AddMonths(1));
				return;
			}

			// month part of caption
			if (m_rcMonth.Contains(e.X, e.Y))
			{
				// display the context menu, the days grid is updated
				// if the user selects a new month
				DisplayMonthMenu(e.X, e.Y);
				return;
			}

			// year part of caption
			if (m_rcYear.Contains(e.X, e.Y))
			{
				// display the number updown year control, the days
				// grid is updated if the user selects a new year
				DisplayYearUpDown(e.X, e.Y);
				return;
			}
			
			// today label
			if (e.Y >= Const.BottomLabelsPos.Y)
			{
				// select today in grid
				UpdateCurSel(m_today);
				this.Close();
				return;
			}
			
			// otherwise, start tracking mouse movements
			m_captureMouse = true;
			UpdateHoverCell(e.X, e.Y);
		}
		
		/// <summary>
		/// User is done hovering over days. Set the current day
		/// if they stopped on a day, otherwise they let up outside
		/// of the day grid.
		/// </summary>
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);

			if (m_captureMouse)
			{
				// done capturing mouse movements
				m_captureMouse = false;
				
				// update the current selection to the day
				// last hovered over
				int index = GetDayIndex(m_hoverSel);
				if (index >= 0 && index < m_days.Length)
				{
					UpdateCurSel(m_hoverSel);
					this.Close();
				}
				else
				{
					// canceled hovering by moving outside of grid
					UpdateCurSel(m_curSel);
				}
			}
		}
		
		/// <summary>
		/// Update the hover cell (mouse-over) if necessary.
		/// </summary>
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			// update the hover cell
			if (m_captureMouse)
				UpdateHoverCell(e.X, e.Y);
		}

		/// <summary>
		/// User can navigate days with the hardware device jog buttons.
		/// </summary>
		protected override void OnKeyUp(KeyEventArgs e)
		{
			// holds the number of days to change
			int days = 0;
			switch (e.KeyCode)
			{
				case Keys.Left:
					days = -1;
					break;
				case Keys.Right:
					days = 1;
					break;
				case Keys.Up:
					days = -7;
					break;
				case Keys.Down:
					days = 7;
					break;
				case Keys.Return:
					this.Close();
					break;
			}
			
			// see if pressed any of the jog buttons
			if (days != 0)
			{
				// calculate the new day that should be selected
				DateTime newDay = m_curSel.AddDays(days);
				if (m_curSel.Month != newDay.Month)
				{
					// user navigated to previous or next month
					UpdateCurSel(newDay);
				}
				else
				{
					// the month did not change so update the current
					// selection by calling CreateGraphics (instead of
					// invalidating and repainting) for better performance
					Graphics g = this.CreateGraphics();
					DrawDay(g, m_curSel, false);
					DrawDay(g, newDay, true);
					g.Dispose();
					m_curSel = newDay;
					
					// update hover selection
					UpdateHoverCell(GetDayIndex(m_curSel));
					
					// raise the ValueChanged event
					if (this.ValueChanged != null)
						ValueChanged(this, EventArgs.Empty);
				}
			}
		}

		/// <summary>
		/// Event from the month context menu. Put a checkmark
		/// next to the currently selected month.
		/// </summary>
		private void OnMonthMenuPopup(System.Object sender, System.EventArgs e)
		{
			// clear all checks
			foreach (MenuItem item in m_monthMenu.MenuItems)
				item.Checked = false;
				
			// check the current month
			if (m_curMonth > 0 && m_curMonth <= 12)
				m_monthMenu.MenuItems[m_curMonth-1].Checked = true;
		}

		/// <summary>
		/// Event from the month context menu. Update the current selection
		/// to the month that was clicked.
		/// </summary>
		private void OnMonthMenuClick(System.Object sender, System.EventArgs e)
		{
			// determine what menu item was clicked
			MenuItem item = sender as MenuItem;
			if (item != null)
			{
				// update the current date selection
				DateTime newDate = DateTime.Parse(
					string.Format("{0}, {1} {2}", 
					item.Text, m_curSel.Day, m_curSel.Year));
				UpdateCurSel(newDate);							
			}
		}

		/// <summary>
		/// Event from year updown control. Update current selection
		/// with the year in the updown control.
		/// </summary>
		private void OnYearUpDownValueChanged(System.Object sender, System.EventArgs e)
		{
			try
			{
				// only want to update the current selection
				// when the user is interacting with the
				// control (when it's visible)
				if (m_yearUpDown.Visible)
				{
					// update the current selection to the year
					DateTime newDate = new DateTime(
						(int)m_yearUpDown.Value,
						m_curSel.Month, m_curSel.Day);
						
					UpdateCurSel(newDate);					
				}
			}
			catch
			{
				// catch if the user entered an invalid year
				// in the control
				m_yearUpDown.Value = m_curSel.Year;
			}
		}
		

		// helper methods


		/// <summary>
		/// Initialize the numeric updown control that is displayed
		/// when the year part of the caption is clicked.
		/// </summary>
		private void InitYearUpDown()
		{
			// create the numeric updown control
			m_yearUpDown = new NumericUpDown();
			this.Controls.Add(m_yearUpDown);
			
			// hookup the valuechanged event
			m_yearUpDown.ValueChanged += new EventHandler(OnYearUpDownValueChanged);

			// init other properties
			m_yearUpDown.Minimum = DateTime.MinValue.Year;
			m_yearUpDown.Maximum = DateTime.MaxValue.Year;
			m_yearUpDown.Visible = false;
		}
		
		/// <summary>
		/// Display the numeric updown year control.
		/// </summary>
		private void DisplayYearUpDown(int x, int y)
		{
			// init year to currently selected year
			m_yearUpDown.Text = m_curSel.Year.ToString();

			// init the position and size of the control
			m_yearUpDown.Left = m_rcYear.Left - 3;
			m_yearUpDown.Top = m_rcYear.Top - 3;
			m_yearUpDown.Width = m_rcYear.Width + 30;
			m_yearUpDown.Height = m_rcYear.Height + 6;
			
			m_yearUpDown.Show();
		}

		/// <summary>
		/// Initialize the context menu that is displayed when the
		/// user clicks the month part of the caption.
		/// </summary>
		private void InitMonthContextMenu()
		{
			// create a menu that contains list of months
			m_monthMenu = new ContextMenu();

			for (int i=1; i <= 12; i++)
			{
				// create new menu item and hookup the click event
				MenuItem item = new MenuItem();
				m_monthMenu.MenuItems.Add(item);
				item.Click += new EventHandler(OnMonthMenuClick);
				item.Text = DateTime.Parse(
					string.Format("{0}/1/2000", i)).ToString("MMMM");
			}

			// hookup popup event so can check the current month			
			m_monthMenu.Popup += new EventHandler(OnMonthMenuPopup);
		}

		/// <summary>
		/// Show the month context menu. The current month
		/// is checked in the popup event.
		/// </summary>
		private void DisplayMonthMenu(int x, int y)
		{
			m_monthMenu.Show(this, new Point(x, y));
		}
		
		/// <summary>
		/// Calculates the date for the first cell in the days
		/// grid. Always show at least one day of previous month.
		/// </summary>
		private void CalculateFirstDate()
		{
			m_firstDate = new DateTime(m_curSel.Year, m_curSel.Month, 1);

			if (m_firstDate.DayOfWeek == DayOfWeek.Sunday)
				m_firstDate = m_firstDate.AddDays(-7);
			else
				m_firstDate = m_firstDate.AddDays(-(int)m_firstDate.DayOfWeek);
		}
		
		/// <summary>
		/// Calculate and cache the days that are displayed in the calendar. 
		/// The days are cached for better performance, each day is only 8 bytes.
		/// </summary>
		private void CalculateDays()
		{
			for (int i=0; i < m_days.Length; i++)
				m_days[i] = m_firstDate.AddDays(i);
		}
		
		/// <summary>
		/// Return the upper left x / y coordinates for the specified index.
		/// </summary>
		private Point GetDayCellPosition(int index)
		{
			// calculate the x and y coordinates for the specified index
			return new Point(
				Const.DaysGrid.X + (((int)index % Const.NumCols) * Const.DaysCell.Width),
				Const.DaysGrid.Y + (((int)index / Const.NumCols) * (Const.DaysCell.Height+1)));
		}
		
		/// <summary>
		/// Create memory bitmap for double-buffering.
		/// </summary>
		private void CreateMemoryBitmap()
		{
			// see if need to create memory bitmap
			if (m_bmp == null || m_bmp.Width != this.Width || m_bmp.Height != this.Height)
			{
				// create the memory bitmap
				m_bmp = new Bitmap(this.Width, this.Height);
				m_graphics = Graphics.FromImage(m_bmp);	
				
				// calculate the coordinates of the left and right
				// arrow buttons now instead of each time paint
				
				// left button
				m_rcLeftButton = new Rectangle(
					Const.ArrowButtonOffset.Width, Const.ArrowButtonOffset.Height,
					Const.ArrowButtonSize.Width, Const.ArrowButtonSize.Height);
				
				// right button
				m_rcRightButton = new Rectangle(
					this.Width - Const.ArrowButtonOffset.Width - Const.ArrowButtonSize.Width - 1,
					Const.ArrowButtonOffset.Height, Const.ArrowButtonSize.Width, Const.ArrowButtonSize.Height);
				
				// left arrow in button
				m_leftArrowPoints[0].X = Const.ArrowPointsOffset.Width;
				m_leftArrowPoints[0].Y = Const.ArrowPointsOffset.Height + (Const.ArrowPointsSize.Height/2);
				m_leftArrowPoints[1].X = m_leftArrowPoints[0].X + Const.ArrowPointsSize.Width;
				m_leftArrowPoints[1].Y = Const.ArrowPointsOffset.Height;
				m_leftArrowPoints[2].X = m_leftArrowPoints[1].X;
				m_leftArrowPoints[2].Y = m_leftArrowPoints[1].Y + Const.ArrowPointsSize.Height;

				// right arrow in button
				m_rightArrowPoints = (Point[])m_leftArrowPoints.Clone();			
				m_rightArrowPoints[0].X = this.Width - Const.ArrowPointsOffset.Width;
				m_rightArrowPoints[1].X = m_rightArrowPoints[2].X = 
					m_rightArrowPoints[0].X - Const.ArrowPointsSize.Width;
			}
		}
		
		/// <summary>
		/// Create any gdi objects required for drawing.
		/// </summary>
		private void CreateGdiObjects()
		{
			if (m_font == null)
				m_font = new Font(Const.FontName, Const.FontSize, FontStyle.Regular);

			// days grid
			if (m_brushCur == null || m_brushCur.Color != this.ForeColor)
				m_brushCur = new SolidBrush(this.ForeColor);
				
			if (m_brushOther == null)
				m_brushOther = new SolidBrush(SystemColors.GrayText);
			
			if (m_brushSelBack == null)
				m_brushSelBack = new SolidBrush(SystemColors.Highlight);
		
			if (m_brushSelText == null)				
				m_brushSelText = new SolidBrush(SystemColors.HighlightText);
				
			if (m_penHoverBox == null)
				m_penHoverBox = new Pen(SystemColors.GrayText);

			// caption
			if (m_brushCaptionBack == null)
				m_brushCaptionBack = new SolidBrush(SystemColors.ActiveCaption);

			if (m_brushCaptionText == null)				
				m_brushCaptionText = new SolidBrush(SystemColors.ActiveCaptionText);

			if (m_fontCaption == null)				
				m_fontCaption = new Font(Const.FontName, Const.FontSize, FontStyle.Bold);
			
			// general
			if (m_brushBack == null || m_brushBack.Color != this.BackColor)
				m_brushBack = new SolidBrush(this.BackColor);

			if (m_penBack == null || m_penBack.Color != this.BackColor)				
				m_penBack = new Pen(this.BackColor);
				
			if (m_brushFrame == null)
				m_brushFrame = new SolidBrush(SystemColors.WindowFrame);
			
			if (m_penFrame == null)
				m_penFrame = new Pen(SystemColors.WindowFrame);		
		}

		/// <summary>
		/// Update the current selection with the specified date.
		/// </summary>
		private void UpdateCurSel(DateTime newDate)
		{
			// see if should raise ValueChanged event
			bool raiseEvent = (m_curSel != newDate) ? true : false;
			
			// store new date selection
			m_curSel = newDate;
			m_hoverSel = m_curSel;
			
			// repaint
			Invalidate();
			Update();

			// raise ValueChanged event
			if (this.ValueChanged != null && raiseEvent)
				ValueChanged(this, EventArgs.Empty);
		}
		
		/// <summary>
		/// Return index into days array for the specified date.
		/// </summary>
		private int GetDayIndex(DateTime date)
		{
			TimeSpan span = date.Subtract(m_firstDate);
			return (int)span.TotalDays;
		}

		/// <summary>
		/// Return index into the days array for the specified coordinates.
		/// </summary>
		private int GetDayIndex(int x, int y)
		{
			// see if in the day grid bounding rectangle
			Rectangle rc = new Rectangle(
				0, Const.DaysGrid.Y,
				Const.NumCols * Const.DaysCell.Width,
				Const.BottomLabelsPos.Y);

			if (!rc.Contains(x, y))
				return -1;
	
			// calculate the index 			
			return (x / Const.DaysCell.Width) + 
				(((y-Const.DaysGrid.Y) / (Const.DaysCell.Height+1)) * Const.NumCols);
		}

		/// <summary>
		/// Update the cell that has the hover mark.
		/// </summary>
		private void UpdateHoverCell(int x, int y)
		{
			// calculate index into grid and then update the cell
			int index = GetDayIndex(x, y);
			UpdateHoverCell(index);
		}
		
		/// <summary>
		/// Update the cell that has the hover mark. Call CreateGraphics
		/// instead of invalidating for better performance.
		/// </summary>
		private void UpdateHoverCell(int newIndex)
		{
			// see if over the days grid
			if (newIndex < 0 || newIndex >= m_days.Length)
			{
				// outside of grid, erase current hover mark
				Graphics g = this.CreateGraphics();
				DrawHoverSelection(g, m_hoverSel, false);
				DrawTodaySelection(g);
				g.Dispose();
				
				m_hoverSel = DateTime.MinValue;
				return;
			}

			// see if hover date has changed			
			if (m_hoverSel != m_days[newIndex])
			{
				// earase old hover mark and draw new mark
				Graphics g = this.CreateGraphics();
				DrawHoverSelection(g, m_hoverSel, false);
				DrawHoverSelection(g, m_days[newIndex], true);
				DrawTodaySelection(g);
				g.Dispose();
				
				// store current hover date
				m_hoverSel = m_days[newIndex];
			}
		}			
		
		/// <summary>
		/// Close the control. Raise the CloseUp event.
		/// </summary>
		private void Close()
		{
			this.Hide();

			// raise the CloseUp event			
			if (this.CloseUp != null)
				CloseUp(this, EventArgs.Empty);
		}

	}
	 
	#endregion
}
