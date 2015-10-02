using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;



namespace TesteWord
{
    class Word
    {
        Dim word As Application = New Application()
        Dim doc As Document = word.Documents.Open("c:\document.docx")
        doc.Activate()
        doc.SaveAs2("c:\document.pdf", WdSaveFormat.wdFormatPDF)
        doc.Close()



    }
}
