using Editor;

var editor = new Editor.Editor();
var history = new EditorHistory();
editor.SetContent("Sohrab");
history.Push(editor.CreateState());
editor.SetContent("-");
history.Push(editor.CreateState());
editor.SetContent("Sardari");
history.Push(editor.CreateState());
Console.WriteLine(editor.Content);
history.Undo();
editor.Restore(history.Undo());
Console.WriteLine(editor.Content);