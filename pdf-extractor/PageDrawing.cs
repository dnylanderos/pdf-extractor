namespace pdf_extractor;

/// <summary>
/// Represents a page extracted from a PDF document with associated drawing-related details.
/// </summary>
public class PageDrawing
{
    private int _pageNumber;
    private string _pageTitle;
    private string _drawingTitle;
    private string _drawingLabel;

    public PageDrawing()
    {
        _pageNumber = 0;
        _pageTitle = "default page title";
        _drawingTitle = "default drawing title";
        _drawingLabel = "default drawing label";
    }
    
    public PageDrawing(int pageNumber, string pageTitle, string drawingTitle, string drawingLabel)
    {
        _pageNumber = pageNumber;
        _pageTitle = pageTitle;
        _drawingTitle = drawingTitle;
        _drawingLabel = drawingLabel;
    }


    public int PageNumber
    {
        get => _pageNumber;
        set => _pageNumber = value;
    }
    
    public string PageTitle
    {
        get => _pageTitle;
        set => _pageTitle = value ?? throw new ArgumentNullException(nameof(value));
    }


    public string DrawingTitle
    {
        get => _drawingTitle;
        set => _drawingTitle = value;
    }


    public string DrawingLabel
    {
        get => _drawingLabel;
        set => _drawingLabel = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}