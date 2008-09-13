// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.Action FileAction;
    
    private Gtk.Action ExitAction;
    
    private Gtk.Action ToolsAction;
    
    private Gtk.ToggleAction RecordImagesAction;
    
    private Gtk.VBox vbox1;
    
    private Gtk.MenuBar menubar1;
    
    private Gtk.HBox hbox1;
    
    private Gtk.Image leftimage;
    
    private Gtk.Image rightimage;
    
    private Gtk.HBox hbox2;
    
    private Gtk.CheckButton chkRecord;
    
    private Gtk.CheckButton chkCalibrateLeft;
    
    private Gtk.CheckButton chkCalibrateRight;
    
    private Gtk.Button cmdCalibrateAlignment;
    
    private Gtk.HBox hbox3;
    
    private Gtk.Button cmdSimpleStereo;
    
    private Gtk.Button cmdDenseStereo;
    
    private Gtk.Button cmdSaveCalibration;
    
    private Gtk.Button cmdSaveCalibrationImage;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        Gtk.UIManager w1 = new Gtk.UIManager();
        Gtk.ActionGroup w2 = new Gtk.ActionGroup("New Action Group");
        w1.InsertActionGroup(w2, 0);
        Gtk.ActionGroup w3 = new Gtk.ActionGroup("Default");
        this.FileAction = new Gtk.Action("FileAction", Mono.Unix.Catalog.GetString("File"), null, null);
        this.FileAction.ShortLabel = Mono.Unix.Catalog.GetString("File");
        w3.Add(this.FileAction, null);
        this.ExitAction = new Gtk.Action("ExitAction", Mono.Unix.Catalog.GetString("Exit"), null, "gtk-stop");
        this.ExitAction.ShortLabel = Mono.Unix.Catalog.GetString("Exit");
        w3.Add(this.ExitAction, null);
        this.ToolsAction = new Gtk.Action("ToolsAction", Mono.Unix.Catalog.GetString("Tools"), null, null);
        this.ToolsAction.ShortLabel = Mono.Unix.Catalog.GetString("Tools");
        w3.Add(this.ToolsAction, null);
        this.RecordImagesAction = new Gtk.ToggleAction("RecordImagesAction", Mono.Unix.Catalog.GetString("Record images"), null, null);
        this.RecordImagesAction.Active = true;
        this.RecordImagesAction.ShortLabel = Mono.Unix.Catalog.GetString("Record images");
        w3.Add(this.RecordImagesAction, null);
        w1.InsertActionGroup(w3, 1);
        this.AddAccelGroup(w1.AccelGroup);
        this.CanFocus = true;
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("Webcam SVS");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        w1.AddUiFromString("<ui><menubar name='menubar1'><menu action='FileAction'><menuitem action='ExitAction'/></menu><menu action='ToolsAction'><menuitem action='RecordImagesAction'/></menu></menubar></ui>");
        this.menubar1 = ((Gtk.MenuBar)(w1.GetWidget("/menubar1")));
        this.menubar1.Name = "menubar1";
        this.vbox1.Add(this.menubar1);
        Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
        w4.Position = 0;
        w4.Expand = false;
        w4.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox1 = new Gtk.HBox();
        this.hbox1.Name = "hbox1";
        this.hbox1.Spacing = 6;
        // Container child hbox1.Gtk.Box+BoxChild
        this.leftimage = new Gtk.Image();
        this.leftimage.Name = "leftimage";
        this.hbox1.Add(this.leftimage);
        Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.leftimage]));
        w5.Position = 0;
        // Container child hbox1.Gtk.Box+BoxChild
        this.rightimage = new Gtk.Image();
        this.rightimage.Name = "rightimage";
        this.hbox1.Add(this.rightimage);
        Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox1[this.rightimage]));
        w6.Position = 1;
        this.vbox1.Add(this.hbox1);
        Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
        w7.Position = 1;
        w7.Expand = false;
        w7.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox2 = new Gtk.HBox();
        this.hbox2.Name = "hbox2";
        this.hbox2.Spacing = 6;
        // Container child hbox2.Gtk.Box+BoxChild
        this.chkRecord = new Gtk.CheckButton();
        this.chkRecord.CanFocus = true;
        this.chkRecord.Name = "chkRecord";
        this.chkRecord.Label = Mono.Unix.Catalog.GetString("Record");
        this.chkRecord.DrawIndicator = true;
        this.chkRecord.UseUnderline = true;
        this.hbox2.Add(this.chkRecord);
        Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox2[this.chkRecord]));
        w8.Position = 0;
        // Container child hbox2.Gtk.Box+BoxChild
        this.chkCalibrateLeft = new Gtk.CheckButton();
        this.chkCalibrateLeft.CanFocus = true;
        this.chkCalibrateLeft.Name = "chkCalibrateLeft";
        this.chkCalibrateLeft.Label = Mono.Unix.Catalog.GetString("Calibrate left camera");
        this.chkCalibrateLeft.DrawIndicator = true;
        this.chkCalibrateLeft.UseUnderline = true;
        this.hbox2.Add(this.chkCalibrateLeft);
        Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox2[this.chkCalibrateLeft]));
        w9.Position = 1;
        // Container child hbox2.Gtk.Box+BoxChild
        this.chkCalibrateRight = new Gtk.CheckButton();
        this.chkCalibrateRight.CanFocus = true;
        this.chkCalibrateRight.Name = "chkCalibrateRight";
        this.chkCalibrateRight.Label = Mono.Unix.Catalog.GetString("Calibrate right camera");
        this.chkCalibrateRight.DrawIndicator = true;
        this.chkCalibrateRight.UseUnderline = true;
        this.hbox2.Add(this.chkCalibrateRight);
        Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox2[this.chkCalibrateRight]));
        w10.Position = 2;
        // Container child hbox2.Gtk.Box+BoxChild
        this.cmdCalibrateAlignment = new Gtk.Button();
        this.cmdCalibrateAlignment.CanFocus = true;
        this.cmdCalibrateAlignment.Name = "cmdCalibrateAlignment";
        this.cmdCalibrateAlignment.UseUnderline = true;
        this.cmdCalibrateAlignment.Label = Mono.Unix.Catalog.GetString("Calibrate Alignment");
        this.hbox2.Add(this.cmdCalibrateAlignment);
        Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox2[this.cmdCalibrateAlignment]));
        w11.PackType = ((Gtk.PackType)(1));
        w11.Position = 3;
        w11.Expand = false;
        w11.Fill = false;
        this.vbox1.Add(this.hbox2);
        Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
        w12.Position = 2;
        w12.Expand = false;
        w12.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox3 = new Gtk.HBox();
        this.hbox3.Name = "hbox3";
        this.hbox3.Spacing = 6;
        // Container child hbox3.Gtk.Box+BoxChild
        this.cmdSimpleStereo = new Gtk.Button();
        this.cmdSimpleStereo.CanFocus = true;
        this.cmdSimpleStereo.Name = "cmdSimpleStereo";
        this.cmdSimpleStereo.UseUnderline = true;
        this.cmdSimpleStereo.Label = Mono.Unix.Catalog.GetString("Simple Stereo");
        this.hbox3.Add(this.cmdSimpleStereo);
        Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox3[this.cmdSimpleStereo]));
        w13.Position = 0;
        w13.Expand = false;
        w13.Fill = false;
        // Container child hbox3.Gtk.Box+BoxChild
        this.cmdDenseStereo = new Gtk.Button();
        this.cmdDenseStereo.CanFocus = true;
        this.cmdDenseStereo.Name = "cmdDenseStereo";
        this.cmdDenseStereo.UseUnderline = true;
        this.cmdDenseStereo.Label = Mono.Unix.Catalog.GetString("Dense Stereo");
        this.hbox3.Add(this.cmdDenseStereo);
        Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox3[this.cmdDenseStereo]));
        w14.Position = 1;
        w14.Expand = false;
        w14.Fill = false;
        // Container child hbox3.Gtk.Box+BoxChild
        this.cmdSaveCalibration = new Gtk.Button();
        this.cmdSaveCalibration.CanFocus = true;
        this.cmdSaveCalibration.Name = "cmdSaveCalibration";
        this.cmdSaveCalibration.UseUnderline = true;
        this.cmdSaveCalibration.Label = Mono.Unix.Catalog.GetString("Save calibration file");
        this.hbox3.Add(this.cmdSaveCalibration);
        Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox3[this.cmdSaveCalibration]));
        w15.Position = 3;
        w15.Expand = false;
        w15.Fill = false;
        // Container child hbox3.Gtk.Box+BoxChild
        this.cmdSaveCalibrationImage = new Gtk.Button();
        this.cmdSaveCalibrationImage.CanFocus = true;
        this.cmdSaveCalibrationImage.Name = "cmdSaveCalibrationImage";
        this.cmdSaveCalibrationImage.UseUnderline = true;
        this.cmdSaveCalibrationImage.Label = Mono.Unix.Catalog.GetString("Save calibration image");
        this.hbox3.Add(this.cmdSaveCalibrationImage);
        Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.hbox3[this.cmdSaveCalibrationImage]));
        w16.Position = 4;
        w16.Expand = false;
        w16.Fill = false;
        this.vbox1.Add(this.hbox3);
        Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
        w17.PackType = ((Gtk.PackType)(1));
        w17.Position = 3;
        w17.Expand = false;
        w17.Fill = false;
        this.Add(this.vbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 558;
        this.DefaultHeight = 300;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.ExitAction.Activated += new System.EventHandler(this.OnExitActionActivated);
        this.RecordImagesAction.Activated += new System.EventHandler(this.OnRecordImagesActionActivated);
        this.chkRecord.Clicked += new System.EventHandler(this.OnChkRecordClicked);
        this.chkCalibrateLeft.Clicked += new System.EventHandler(this.OnChkCalibrateLeftClicked);
        this.chkCalibrateRight.Clicked += new System.EventHandler(this.OnChkCalibrateRightClicked);
        this.cmdCalibrateAlignment.Clicked += new System.EventHandler(this.OnCmdCalibrateAlignmentClicked);
        this.cmdSimpleStereo.Clicked += new System.EventHandler(this.OnCmdSimpleStereoClicked);
        this.cmdDenseStereo.Clicked += new System.EventHandler(this.OnCmdDenseStereoClicked);
        this.cmdSaveCalibration.Clicked += new System.EventHandler(this.OnCmdSaveCalibrationClicked);
        this.cmdSaveCalibrationImage.Clicked += new System.EventHandler(this.OnCmdSaveCalibrationImageClicked);
    }
}