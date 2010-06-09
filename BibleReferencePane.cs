
using System.Windows.Forms;
using Logos4Lib;

namespace Logos4ComApiDemo
{
	public partial class BibleReferencePane : UserControl
	{
		public BibleReferencePane(LogosDataTypeReference reference)
		{
			m_reference = reference;

			InitializeComponent();
		}

		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);

			FirstBookLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).FirstBook;
			LastBookLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).LastBook;
			FirstChapterLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).FirstChapter;
			LastChapterLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).LastChapter;
			FirstVerseLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).FirstVerse;
			LastVerseLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).LastVerse;
			PreviousBookLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).PreviousBook;
			NextBookLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).NextBook;
			PreviousChapterLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).PreviousChapter;
			NextChapterLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).NextChapter;
			PreviousVerseLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).PreviousVerse;
			NextVerseLink.Reference = ((LogosBibleReferenceDetails) m_reference.Details).NextVerse;
		}

		readonly LogosDataTypeReference m_reference;
	}
}
