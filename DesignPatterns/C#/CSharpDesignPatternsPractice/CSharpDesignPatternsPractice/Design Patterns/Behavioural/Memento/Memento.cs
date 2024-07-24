//Memento is a behavioral design pattern that lets 
//you save and restore the previous state of an object without revealing the details of its implementation.
//DocumentClass document = new DocumentClass("Initial content\n");
//History history = new History();

//// Write some content
//document.write("Additional content\n");
//history.addMemento(document.createMemento());

//// Write more content
//document.write("More content\n");
//history.addMemento(document.createMemento());

//// Restore to previous state
//document.restoreFromMemento(history.getMemento(1));

//// Print document content
//Console.WriteLine(document.getContent());
public class DocumentClass
{
    private String content;

    public DocumentClass(String content)
    {
        this.content = content;
    }

    public void write(String text)
    {
        this.content += text;
    }

    public String getContent()
    {
        return this.content;
    }

    public DocumentMemento createMemento()
    {
        return new DocumentMemento(this.content);
    }

    public void restoreFromMemento(DocumentMemento memento)
    {
        this.content = memento.getSavedContent();
    }
}


public class DocumentMemento
{
    private String content;

    public DocumentMemento(String content)
    {
        this.content = content;
    }

    public String getSavedContent()
    {
        return this.content;
    }
}


public class History
{
    private List<DocumentMemento> mementos;

    public History()
    {
        this.mementos = new List<DocumentMemento>();
    }

    public void addMemento(DocumentMemento memento)
    {
        this.mementos.Add(memento);
    }

    public DocumentMemento getMemento(int index)
    {
        return this.mementos[index];
    }
}