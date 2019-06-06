using System;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.Xml;

namespace UnitaleFontMaker
{

	public class FontXml
	{
		private XmlDocument doc;
		private XmlElement font;
		private XmlElement voice;
		private XmlElement lineSpacing;
		private XmlElement spriteSheet;
		private Character[] chars;
		
		public string Voice 
		{
			get { return voice.InnerText; }
			set { voice.InnerText = value; }
		}
		
		public string LineSpacing 
		{
			get { return lineSpacing.InnerText; }
			set { lineSpacing.InnerText = value; }
		}
		
		public Character[] Characters 
		{
			get { return chars; }
			set { chars = value; }
		}
		
		public FontXml()
		{
			doc = new XmlDocument();//创建XML文档
			
			XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "utf-8", null);//XML文档声明
			doc.AppendChild(decl);//插入文档声明
			
			font = doc.CreateElement("font");//创建 font 元素
			doc.AppendChild(font);
			
			voice = doc.CreateElement("voice");
			font.AppendChild(voice);
			
			lineSpacing = doc.CreateElement("linespacing");
			font.AppendChild(lineSpacing);
			
			spriteSheet = doc.CreateElement("spritesheet");
			font.AppendChild(spriteSheet);
		}
		
		public void Save(string path)
		{
			for (int i = 0; i < Characters.Length; i++) 
			{
				XmlElement spr = doc.CreateElement("sprite");
				string name = CheckSpecialChar(Characters[i].Char.ToString());
				spr.SetAttribute("name", name);
				spriteSheet.AppendChild(spr);
				
				XmlElement rect = doc.CreateElement("rect");

				rect.SetAttribute("x", ((int)Characters[i].X).ToString());
				rect.SetAttribute("y", ((int)Characters[i].Y).ToString());
				rect.SetAttribute("w", ((int)Characters[i].Width).ToString());
				rect.SetAttribute("h", ((int)Characters[i].Height).ToString());
				spr.AppendChild(rect);
			}
			
			doc.Save(path);
		}
		
		public string CheckSpecialChar(string str)
		{
			switch (str) 
			{
				case "/":
					return "slash";

				case ".":
					return "dot";

				case "|":
					return "pipe";

				case "\\":
					return "backslash";

				case ":":
					return "colon";

				case "?":
					return "questionmark";

				case "\"":
					return "doublequote";

				case "*":
					return "asterisk";

				case " ":
					return "space";

				case "<":
					return "lt";

				case ">":
					return "rt";

				case "&":
					return "ampersand";
			}
			
			return str;
		}
	}
}
