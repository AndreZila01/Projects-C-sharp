using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public class ColorPBC : Control
	{


		private int _Value = 0;
		private int _Minimum = 0;
		private int _Maximum = 100;
		private int _Step = 10;
		private ColorPBC.FillStyles _FillStyle = ColorPBC.FillStyles.Dashed;
		private Color _BarColor = Color.FromArgb((int)byte.MaxValue, 128, 128);
		private Color _BorderColor = Color.Black;

		public ColorPBC()
		{
			this.Size = new Size(150, 15);
			this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
		}

		[Category("ColorPBC")]
		[Description("ColorPBC color")]
		public Color BarColor
		{
			get
			{
				return this._BarColor;
			}
			set
			{
				this._BarColor = value;
				this.Invalidate();
			}
		}

		[Category("ColorPBC")]
		[Description("ColorPBC fill style")]
		public ColorPBC.FillStyles FillStyle
		{
			get
			{
				return this._FillStyle;
			}
			set
			{
				this._FillStyle = value;
				this.Invalidate();
			}
		}

		[Category("ColorPBC")]
		[Description("The current value for the ColorPBC, in the range specified by the Minimum and Maximum properties.")]
		[RefreshProperties(RefreshProperties.All)]
		public int Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if (value < this._Minimum)
					throw new ArgumentException("'" + (object)value + "' is not a valid value for 'Value'.\n'Value' must be between 'Minimum' and 'Maximum'.");
				if (value > this._Maximum)
					throw new ArgumentException("'" + (object)value + "' is not a valid value for 'Value'.\n'Value' must be between 'Minimum' and 'Maximum'.");
				this._Value = value;
				this.Invalidate();
			}
		}

		[Category("ColorPBC")]
		[RefreshProperties(RefreshProperties.All)]
		[Description("The lower bound of the range this ColorPBC is working with.")]
		public int Minimum
		{
			get
			{
				return this._Minimum;
			}
			set
			{
				this._Minimum = value;
				if (this._Minimum > this._Maximum)
					this._Maximum = this._Minimum;
				if (this._Minimum > this._Value)
					this._Value = this._Minimum;
				this.Invalidate();
			}
		}

		[RefreshProperties(RefreshProperties.All)]
		[Description("The uppper bound of the range this ColorPBC is working with.")]
		[Category("ColorPBC")]
		public int Maximum
		{
			get
			{
				return this._Maximum;
			}
			set
			{
				this._Maximum = value;
				if (this._Maximum < this._Value)
					this._Value = this._Maximum;
				if (this._Maximum < this._Minimum)
					this._Minimum = this._Maximum;
				this.Invalidate();
			}
		}

		[Description("The amount to jump the current value of the control by when the Step() method is called.")]
		[Category("ColorPBC")]
		public int Step
		{
			get
			{
				return this._Step;
			}
			set
			{
				this._Step = value;
				this.Invalidate();
			}
		}

		[Category("ColorPBC")]
		[Description("The border color of ColorPBC")]
		public Color BorderColor
		{
			get
			{
				return this._BorderColor;
			}
			set
			{
				this._BorderColor = value;
				this.Invalidate();
			}
		}

		public void PerformStep()
		{
			if (this._Value < this._Maximum)
				this._Value += this._Step;
			else
				this._Value = this._Maximum;
			this.Invalidate();
		}

		public void PerformStepBack()
		{
			if (this._Value > this._Minimum)
				this._Value -= this._Step;
			else
				this._Value = this._Minimum;
			this.Invalidate();
		}

		public void Increment(int value)
		{
			if (this._Value < this._Maximum)
				this._Value += value;
			else
				this._Value = this._Maximum;
			this.Invalidate();
		}

		public void Decrement(int value)
		{
			if (this._Value > this._Minimum)
				this._Value -= value;
			else
				this._Value = this._Minimum;
			this.Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Color color1 = ControlPaint.Dark(this._BarColor);//this._BarColor
			SolidBrush solidBrush = new SolidBrush(ControlPaint.LightLight(Color.White));//this._BarColor
			e.Graphics.FillRectangle((Brush)solidBrush, this.ClientRectangle);
			solidBrush.Dispose();
			if (this._Maximum == this._Minimum || this._Value == 0)
			{
				this.drawBorder(e.Graphics);
			}
			else
			{
				int width = this.Width * this._Value / (this._Maximum - this._Minimum);
				if (width == 0)
				{
					this.drawBorder(e.Graphics);
				}
				else
				{
					Rectangle rect1 = new Rectangle(0, 0, width, this.Height / 2);
					Rectangle rect2 = new Rectangle(0, this.Height / 2, width, this.Height / 2);
					LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush(new Point(0, 0), new Point(0, this.Height / 2), color1, this._BarColor);//this._BarColor
					e.Graphics.FillRectangle((Brush)linearGradientBrush1, rect1);
					linearGradientBrush1.Dispose();
					LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(new Point(0, this.Height / 2 - 1), new Point(0, this.Height), this._BarColor, color1);//this._BarColor
					e.Graphics.FillRectangle((Brush)linearGradientBrush2, rect2);
					linearGradientBrush2.Dispose();
					int num1 = (int)((double)this.Height * 0.67);
					int num2 = width / num1;
					Color color2 = ControlPaint.LightLight(this._BarColor);//this._BarColor
					switch (this._FillStyle)
					{
						case ColorPBC.FillStyles.Dashed:
							for (int index = 1; index <= num2; ++index)
								e.Graphics.DrawLine(new Pen(color2, 1f), num1 * index, 0, num1 * index, this.Height);
							break;
					}
					this.drawBorder(e.Graphics);
				}
			}
		}

		protected void drawBorder(Graphics g)
		{
			Rectangle rect = new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
			g.DrawRectangle(new Pen(this._BorderColor, 1f), rect);
		}

		public enum FillStyles
		{
			Solid,
			Dashed,
		}
	}
}

