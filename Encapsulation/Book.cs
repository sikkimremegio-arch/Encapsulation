using System;

public class Book
{
    private int _pagesRead;

    public Book(int pagesRead)
    {
        _pagesRead = pagesRead; 

    }
    public int PagesRead
    {
        get { return _pagesRead; }
        set
        {
            if (_pagesRead != value)
            {
                _pagesRead = value; 
            }
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
    }

}