namespace pdf_extractor;

public class PageDrawing
{
    private int _pageNumber;
    private string _pageTitle;
    private int _sheetTitle;
    
    public PageDrawing()
    {
        _pageNumber = 0;
        _pageTitle = "default";
        _sheetTitle = 0;
    }

    public PageDrawing(int pageNumber, string pageTitle, int sheetTitle)
    {
        _pageNumber = pageNumber;
        _pageTitle = pageTitle;
        _sheetTitle = sheetTitle;
    }
    
    

    
}