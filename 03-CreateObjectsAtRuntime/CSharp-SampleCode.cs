//WDS.DarkBrain®(DarkSystemCD)[Logic Production Engine]                       ;

//[?]Create Window at Runtime :: Windows Presentation Foundation {WPF}
Window myWindow = new Window();
myWindow.Name = "myWindow1";
myWindow.Show();
//[?]Create Canvas Container :: Windows Presentation Foundation {WPF}
Canvas myCanvas = new Canvas();
myCanvas.Name = "myCanvas1";
myCanvas.Width = Double.NaN;
myCanvas.Height = Double.NaN;
//[?]Create Button :: Windows Presentation Foundation {WPF}
Button myButton = new Button();
myButton.Name = "myButton1";
muButton.Content = "myButton1";
//add myButton to myCanvas;
myCanvas.Children.Add(myButton);
//add myCanvas and myCanvas Content to myWindow
myWindow.Content = myCanvas;
