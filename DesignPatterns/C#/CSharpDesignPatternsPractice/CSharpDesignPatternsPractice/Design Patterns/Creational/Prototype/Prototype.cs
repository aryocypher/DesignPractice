using System.Xml.Linq;

//Document doc = new Document();
//doc.CreatedDate = DateTime.Now;
//doc.DocInfo = new DocInfo();
//doc.DocInfo.Content = "Abc";
//doc.DocInfo.DocumentName = "Original";
//var shallowCopiedDoc = doc.ShallowCopy();
//doc.DocInfo.Content = "Def";
//Console.WriteLine($"{doc.DocInfo.Content}+{doc.DocInfo.DocumentName}");
//var DeepCopy = doc.DeepCopy();
//doc.DocInfo.Content = "Ghi";
//Console.WriteLine($"{doc.DocInfo.Content}+{doc.DocInfo.DocumentName}");




public class Document
    {
        public DateTime CreatedDate { get; set; }
        
        public DocInfo DocInfo { get;set;}

        public Document ShallowCopy()
        {
            Document doc= (Document)this.MemberwiseClone();
            return doc; 
        }

        public Document DeepCopy()
        {
            Document doc = (Document)this.MemberwiseClone();
            doc.DocInfo= new DocInfo();
            doc.DocInfo.DocumentName=this.DocInfo.DocumentName;
            doc.DocInfo.Content=this.DocInfo.Content;
            return doc;
        }
        
}

public class DocInfo
{
    public string DocumentName { get; set; }
    public string Content { get; set; }
}

