using Eto.Forms;
using Eto.Drawing;
using Eto.IO;
using SD = System.Drawing;
using SWF = System.Windows.Forms;
using Eto.Platform.Windows.Drawing;
using Eto.Platform.Windows.Forms;
using Eto.Platform.Windows.Forms.Printing;
using Eto.Platform.Windows.Forms.Controls;
using Eto.Platform.Windows.IO;
using Eto.Forms.ThemedControls;

namespace Eto.Platform.Windows
{
	public class Generator : Eto.Generator
	{
		public override string ID { get { return Generators.Windows; } }

		static readonly EmbeddedAssemblyLoader embeddedAssemblies = EmbeddedAssemblyLoader.Register("Eto.Platform.Windows.CustomControls.Assemblies");

		public Generator()
		{
			AddTo(this);
		}

		public static void AddTo(Eto.Generator g)
		{
			// Drawing
			g.Add<IBitmap>(() => new BitmapHandler());
			g.Add<IFontFamily>(() => new FontFamilyHandler());
			g.Add<IFont>(() => new FontHandler());
			g.Add<IFonts>(() => new FontsHandler());
			g.Add<IGraphics>(() => new GraphicsHandler());
			g.Add<IGraphicsPathHandler>(() => new GraphicsPathHandler());
			g.Add<IIcon>(() => new IconHandler());
			g.Add<IIndexedBitmap>(() => new IndexedBitmapHandler());
			g.Add<IMatrixHandler>(() => new MatrixHandler());
			g.Add<IPen>(() => new PenHandler());
			g.Add<ISolidBrush>(() => new SolidBrushHandler());
			g.Add<ITextureBrush>(() => new TextureBrushHandler());
			g.Add<ILinearGradientBrush>(() => new LinearGradientBrushHandler());

			// Forms.Cells
			g.Add<ICheckBoxCell>(() => new CheckBoxCellHandler());
			g.Add<IComboBoxCell>(() => new ComboBoxCellHandler());
			g.Add<IImageTextCell>(() => new ImageTextCellHandler());
			g.Add<IImageViewCell>(() => new ImageViewCellHandler());
			g.Add<ITextBoxCell>(() => new TextBoxCellHandler());
			g.Add<IDrawableCell>(() => new DrawableCellHandler());
			
			// Forms.Controls
			g.Add<IButton>(() => new ButtonHandler());
			g.Add<ICheckBox>(() => new CheckBoxHandler());
			g.Add<IComboBox>(() => new ComboBoxHandler());
			g.Add<IDateTimePicker>(() => new DateTimePickerHandler());
			g.Add<IDrawable>(() => new DrawableHandler());
			g.Add<IGridColumn>(() => new GridColumnHandler());
			g.Add<IGridView>(() => new GridViewHandler());
			g.Add<IGroupBox>(() => new GroupBoxHandler());
			g.Add<IImageView>(() => new ImageViewHandler());
			g.Add<ILabel>(() => new LabelHandler());
			g.Add<IListBox>(() => new ListBoxHandler());
			g.Add<INumericUpDown>(() => new NumericUpDownHandler());
			g.Add<IPanel>(() => new PanelHandler());
			g.Add<IPasswordBox>(() => new PasswordBoxHandler());
			g.Add<IProgressBar>(() => new ProgressBarHandler());
			g.Add<IRadioButton>(() => new RadioButtonHandler());
			g.Add<IScrollable>(() => new ScrollableHandler());
			g.Add<ISearchBox>(() => new SearchBoxHandler());
			g.Add<ISlider>(() => new SliderHandler());
			g.Add<ISpinner>(() => new ThemedSpinnerHandler());
			g.Add<ISplitter>(() => new SplitterHandler());
			g.Add<ITabControl>(() => new TabControlHandler());
			g.Add<ITabPage>(() => new TabPageHandler());
			g.Add<ITextArea>(() => new TextAreaHandler());
			g.Add<ITextBox>(() => new TextBoxHandler());
			g.Add<ITreeGridView>(() => new TreeGridViewHandler());
			g.Add<ITreeView>(() => new TreeViewHandler());
			g.Add<IWebView>(() => new WebViewHandler());
			g.Add<IScreens>(() => new ScreensHandler());
			
			// Forms.Menu
			g.Add<ICheckMenuItem>(() => new CheckMenuItemHandler());
			g.Add<IContextMenu>(() => new ContextMenuHandler());
			g.Add<IButtonMenuItem>(() => new ButtonMenuItemHandler());
			g.Add<IMenuBar>(() => new MenuBarHandler());
			g.Add<IRadioMenuItem>(() => new RadioMenuItemHandler());
			g.Add<ISeparatorMenuItem>(() => new SeparatorMenuItemHandler());
			
			// Forms.Printing
			g.Add<IPrintDialog>(() => new PrintDialogHandler());
			g.Add<IPrintDocument>(() => new PrintDocumentHandler());
			g.Add<IPrintSettings>(() => new PrintSettingsHandler());
			
			// Forms.ToolBar
			g.Add<ICheckToolItem>(() => new CheckToolItemHandler());
			g.Add<ISeparatorToolItem>(() => new SeparatorToolBarItemHandler());
			g.Add<IButtonToolItem>(() => new ButtonToolItemHandler());
			g.Add<IToolBar>(() => new ToolBarHandler());
			
			// Forms
			g.Add<IApplication>(() => new ApplicationHandler());
			g.Add<IClipboard>(() => new ClipboardHandler());
			g.Add<IColorDialog>(() => new ColorDialogHandler());
			g.Add<ICursor>(() => new CursorHandler());
			g.Add<IDialog>(() => new DialogHandler());
			g.Add<IFontDialog>(() => new FontDialogHandler());
			g.Add<IForm>(() => new FormHandler());
			g.Add<IMessageBox>(() => new MessageBoxHandler());
			g.Add<IModalWindow>(() => new ModalWindowHandler());
			g.Add<IOpenFileDialog>(() => new OpenFileDialogHandler());
			g.Add<IPixelLayout>(() => new PixelLayoutHandler());
			g.Add<ISaveFileDialog>(() => new SaveFileDialogHandler());
			g.Add<ISelectFolderDialog>(() => new SelectFolderDialogHandler());
			g.Add<ITableLayout>(() => new TableLayoutHandler());
			g.Add<IUITimer>(() => new UITimerHandler());
			g.Add<IMouse>(() => new MouseHandler());
			
			// IO
			g.Add<ISystemIcons>(() => new SystemIconsHandler());
			
			// General
			g.Add<IEtoEnvironment>(() => new EtoEnvironmentHandler());
		}
	}
}
