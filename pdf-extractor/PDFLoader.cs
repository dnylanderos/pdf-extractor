
namespace pdf_extractor;

/// <summary>
/// The PdfLoader class provides functionality to load and manage page drawings from a PDF file,
/// such as extracting pages, renaming them, and representing them as drawing objects.
/// </summary>
public class PdfLoader
{
    private string _pdfPath;
    private List<PageDrawing> _drawings;
    
    public PdfLoader()
    {
        _pdfPath = "default path";
        _drawings = [];
    }
    
    public PdfLoader(string pdfPath)
    {
        throw new NotImplementedException();
    }

    /// Loads and processes the drawing pages from the PDF file associated with the current PdfLoader instance.
    /// This method extracts and organizes page information into a list of PageDrawing objects.
    /// Each PageDrawing object represents individual details such as the page number, title,
    /// associated drawing title, and drawing labels from the PDF.
    /// <returns>Returns a list of PageDrawing objects representing the extracted pages.</returns>
    public List<PageDrawing> LoadDrawingPages()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Renames the titles and labels of a collection of PageDrawing objects.
    /// </summary>
    /// <param name="pages">A list of PageDrawing objects to process and rename.</param>
    public void RenamePages(List<PageDrawing> pages)
    {
        throw new NotImplementedException();
    }


    public override string ToString()
    {
        throw new NotImplementedException();
    }
}