# :open_file_folder: :page_facing_up: (Pascal)<hr>

#### [:speech_balloon:]Create Window at Runtime
<sub>(Sample Code) :: using **Pascal**</sub>
```pascal
var myWindow:Forms.TForm;
begin
myWindow := TForm.Create(Nil);
  with myWindow do begin
    Name := "myWindow1";
    Caption := "myWindow1";
    Visible := True;
  end;
end;
```
<table>
<tr>
<td>:thought_balloon:</td>
<td>
<blockquote>Create Window at Runtime<br><sub>
<b>✧</b> <i>myWindow</i> is made as a variable of <b>TForm</b> <i>Type</i>;</sub><br>
<sup><b>✧</b> using <i>myWindow</i> variable, TForm properties is specified;</sup>
</blockquote>
</td>
</tr>
</table>
<hr>

#### [:speech_balloon:]Create Button
<sub>(Sample Code) :: using **Pascal**</sub>
```pascal
var myButton:StdCtrls.TButton;
begin
myButton := TButton.Create(Nil);
  With myButton do begin
    Parent := myWindow;
    Name := "myButton1";
    Caption := "myButton";
  end;
end;
```
<table>
<tr>
<td>:thought_balloon:</td>
<td>
<blockquote>Create Button<br>
<sub><b>✧</b> <i>myButton</i> is made as a variable of <b>TButton</b> <i>Type</i>;</sub><br>
<sup><b>✧</b> using <i>myButton</i> variable, TButton properties is specified;</sup><br>
<sup><b>✧</b> on this example, <i>myWindow</i> variable must be part of the same procedure\function of myButton variable declaration;</sup>
</blockquote></td>
</tr>
</table>
<hr>

<table><tr><td><!--MainLeft-->
<table><tr><td><!--MainTop-->
<sup><sub>● <a href="https://en.wikipedia.org/wiki/Pascal_(programming_language)">Pascal is a Computer Language by Niklaus Wirth;</a>
<br>● <a href="https://en.wikipedia.org/wiki/Lazarus_(IDE)">Lazarus-IDE is a prograaming tool from Volunteers (Lazarus Team);</a>
<br>● <a href="https://en.wikipedia.org/wiki/Delphi_(IDE)">Delphi is a prograaming tool from Borland;</a></sub></sup></td></tr><tr><td>
<table><tr><td><!--MainBotton-->
<img src="https://i.imgur.com/4HoosJb.jpg" width="56" height="56"></td><td><sub><a href="https://bloodart-magazine.tumblr.com">BloodArt.Magazine</a></sub><br>
<sub>detailed description available in the projects and productions,</sub><br>
<sup>developing delivered to collection information in the magazine.</sup>
</td></tr></table></td></tr></tr></table></td>
<td><!--MainRight-->
  Index<br>
  :file_folder: <a href="https://github.com/DarkSystemCD/Sample-Code">Sample Code</a><br>
  ↳ :file_folder: <a href="https://github.com/DarkSystemCD/Sample-Code/tree/GitHub/03-CreateObjectsAtRuntime">03-CreateObjectsAtRuntime</a>
</td></tr></table>
