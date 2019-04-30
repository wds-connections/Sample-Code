#### [:speech_balloon:]Create Window at Runtime
<sub>(Sample Code) :: Windows Presentation Foundation {WPF} using CSharp | C#</sub>
```c#
Window myWindow = new Window();
myWindow.Name = "myWindow1";
myWindow.Show();
```
<table>
<tr>
<td>:thought_balloon:</td>
<td>
<blockquote>Create Window at Runtime<br><sub><b>✧</b> <i>myWindow</i> is made as a variable of <b>Window</b> <i>Type</i>;</sub><br>
<sup><b>✧</b> using <i>myWindow</i> variable, Window properties is specified;</sup></blockquote>
</td>
</tr>
</table>
<hr>

#### [:speech_balloon:]Create Canvas Container
<sub>(Sample Code) :: Windows Presentation Foundation {WPF} using CSharp | C#</sub>
```c#
Canvas myCanvas = new Canvas();
myCanvas.Name = "myCanvas1";
myCanvas.Width = Double.NaN;
myCanvas.Height = Double.NaN;
```
<table>
<tr>
<td>:thought_balloon:</td>
<td>
<blockquote>Create Canvas Container<br><sub><b>✧</b> <i>myCanvas</i> is made as a variable of <b>Canvas</b> <i>Type</i>;</sub><br>
<sup><b>✧</b> using <i>myCanvas</i> variable, Canvas properties is specified;</sup><br>
<sup><b>✧</b>  Double.NaN property value, is used to specify (Auto) value; making the control adjust with the parent size;</sup></blockquote>
</td>
</tr>
</table>
<hr>

#### [:speech_balloon:]Create Button
<sub>(Sample Code) :: Windows Presentation Foundation {WPF} using CSharp | C#</sub>
```c#
Button myButton = new Button();
myButton.Name = "myButton1";
muButton.Content = "myButton1";
```
<table>
<tr>
<td>:thought_balloon:</td>
<td>
<blockquote>Create Button<br><sub><b>✧</b> <i>myButton</i> is made as a variable of <b>Button</b> <i>Type</i>;</sub><br>
<sup><b>✧</b> using <i>myButton</i> variable, Button properties is specified;</sup></blockquote>
</td>
</tr>
</table>
<hr>

#### [:speech_balloon:]add myButton to myCanvas
<sub>(Sample Code) :: Windows Presentation Foundation {WPF} using CSharp | C#</sub>
```c#
myCanvas.Children.Add(myButton);
```
<table>
<tr>
<td>:thought_balloon:</td>
<td>
<blockquote>add myButton to myCanvas<br><sub><b>✧</b> <i>myCanvas</i> variable is used for Children.Add property indicating <i>myButton</i> value;</sub></blockquote>
</td>
</tr>
</table>
<hr>

#### [:speech_balloon:]add myCanvas to myWindow
<sub>(Sample Code) :: Windows Presentation Foundation {WPF} using CSharp | C#</sub>
```c#
myWindow.Content = myCanvas;
```
<table>
<tr>
<td>:thought_balloon:</td>
<td>
<blockquote>add myCanvas to myWindow<br><sub><b>✧</b> <i>myWindow</i> variable is used for Content property indicating <i>myCanvas</i> value;</sub><br>
<sub><b>✧</b> <i>myCanvas</i> container will be the Content of <i>myWindow</i> carring all the controls added to <i>myCanvas</i> with all the properties specified;</sub></blockquote>
</td>
</tr>
</table>

<hr>

<table>
<tr>
<td><sup><sub>● <a href="https://en.wikipedia.org/wiki/C_Sharp_(programming_language)">CSharp | C# is a Computer Language by Microsoft Technologies;</a>
<br>● <a href="https://en.wikipedia.org/wiki/Windows_Presentation_Foundation">Windows Presentation Foundation is a graphical subsystem by Microsoft Technologies</a>
<br>● <a href="https://en.wikipedia.org/wiki/Microsoft_Visual_Studio">Visual Studio is a prograaming tool from Microsoft Technologies;</a></sub></sup></td></tr>
<tr><td><sub><a href="https://bloodart-magazine.tumblr.com">BloodArt.Magazine</a></sub><br>
<sub>detailed description available in the projects and productions,</sub><br>
<sup>developing delivered to collection information in the magazine.</sup><br>
</td></tr>
</tr>
</table>
