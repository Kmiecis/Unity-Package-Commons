using UnityEngine;

namespace Common
{
	public class Clipboard
	{
		public string Text
		{
			get
			{
				var textEditor = new TextEditor();
				textEditor.Paste();
				return textEditor.text;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
					return;
				var textEditor = new TextEditor();
				textEditor.text = new GUIContent(value).text;
				textEditor.SelectAll();
				textEditor.Copy();
			}
		}
	}
}