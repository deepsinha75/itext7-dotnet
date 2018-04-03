using System;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using iText.Svg.Converter;
using iText.Test;

namespace iText.Svg.Renderers.Impl {
    public class EllipseNodeRendererIntegrationTest {
        public static readonly String sourceFolder = iText.Test.TestUtil.GetParentProjectDirectory(NUnit.Framework.TestContext
            .CurrentContext.TestDirectory) + "/resources/itext/svg/renderers/impl/EllipseSvgNodeRendererTest/";

        public static readonly String destinationFolder = NUnit.Framework.TestContext.CurrentContext.TestDirectory
             + "/test/itext/svg/renderers/impl/EllipseSvgNodeRendererTest/";

        [NUnit.Framework.OneTimeSetUp]
        public static void BeforeClass() {
            ITextTest.CreateDestinationFolder(destinationFolder);
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void BasicEllipseTest() {
            String filename = "basicEllipseTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <rect x=\"20\" y=\"60\" width = \"160\" height=\"80\" stroke='red' />\n" + "    <ellipse cx='100' cy='100' rx='80' ry='40' stroke='green' fill ='cyan'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseCxCyAbsentTest() {
            String filename = "ellipseCxCyAbsentTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <rect x='0' y='0' width = \"800\" height=\"800\" stroke='red' />\n" + "    <ellipse rx='80' ry='40' stroke='green' fill ='cyan'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseCxAbsentTest() {
            String filename = "ellipseCxAbsentTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <rect x='0' y='0' width = \"800\" height=\"800\" stroke='red' />\n" + "    <ellipse cy ='100' rx='80' ry='40' stroke='green' fill ='cyan'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseCxNegativeTest() {
            String filename = "ellipseCxNegativeTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <rect x='0' y='0' width = \"800\" height=\"800\" stroke='red' />\n" + "    <ellipse cx ='-40' cy='100' rx='80' ry='40' stroke='green' fill ='cyan'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseCyNegativeTest() {
            String filename = "ellipseCyNegativeTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <rect x='0' y='0' width = \"800\" height=\"800\" stroke='red' />\n" + "    <ellipse cx ='100' cy='-30' rx='80' ry='60' stroke='green' fill ='cyan'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseCyAbsentTest() {
            String filename = "ellipseCyAbsentTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <rect x='0' y='0' width = \"800\" height=\"800\" stroke='red' />\n" + "    <ellipse cx ='100' rx='80' ry='40' stroke='green' fill ='cyan'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseRxAbsentTest() {
            String filename = "ellipseRxAbsentTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <rect x='0' y='0' width = \"800\" height=\"800\" stroke='red' />\n" + "    <ellipse cx ='100' ct='100' ry='40' stroke='green' fill ='cyan'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseRyAbsentTest() {
            String filename = "ellipseRyAbsentTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <rect x='0' y='0' width = \"800\" height=\"800\" stroke='red' />\n" + "    <ellipse cx ='100' ct='100' rx='40' stroke='green' fill ='cyan'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseRxNegativeTest() {
            String filename = "ellipseRxNegativeTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <rect x='0' y='0' width = \"800\" height=\"800\" stroke='red' />\n" + "    <ellipse cx ='100' ct='100' rx='-50' ry='40' stroke='green' fill ='cyan'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseRyNegativeTest() {
            String filename = "ellipseRyNegativeTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <rect x='0' y='0' width = \"800\" height=\"800\" stroke='red' />\n" + "    <ellipse cx ='100' ct='100' rx='60' ry='-40' stroke='green' fill ='cyan'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseTranslatedTest() {
            String filename = "ellipseTranslatedTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "\t<line x1='100' y1='100' x2='200' y2='100' stroke='black'/>\n" + "\t<line x1='100' y1='100' x2='100' y2='200' stroke='black'/>\n"
                 + "    <ellipse cx='100' cy='100' rx='80' ry='40' transform='translate(100,50)' stroke='green' fill ='cyan'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseRotatedTest() {
            String filename = "ellipseRotatedTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <ellipse rx='80' ry='40' transform='translate(100,100)' stroke='red' fill ='blue'/>\n" + "    <ellipse rx='80' ry='40' transform='translate(100,100) rotate(-25)' stroke='green' fill ='cyan'/>\n"
                 + "\t<line x1='100' y1='100' x2='200' y2='100' stroke='black'/>\n" + "\t<line x1='100' y1='100' x2='100' y2='200' stroke='black'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseScaledUpTest() {
            String filename = "ellipseScaledUpTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "\t<line x1='100' y1='100' x2='200' y2='100' stroke='black'/>\n" + "\t<line x1='100' y1='100' x2='100' y2='200' stroke='black'/>\n"
                 + "    <ellipse rx='80' ry='40' transform='translate(100,100) scale(2)' stroke='green' fill ='cyan'/>\n"
                 + "    <ellipse rx='80' ry='40' transform='translate(100,100)' stroke='red' fill ='green'/> \n" + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseScaledDownTest() {
            String filename = "ellipseScaledDownTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "\t<line x1='100' y1='100' x2='200' y2='100' stroke='black'/>\n" + "\t<line x1='100' y1='100' x2='100' y2='200' stroke='black'/>\n"
                 + "    <ellipse rx='80' ry='40' transform='translate(100,100)' stroke='green' fill ='cyan'/>\n" + "    <ellipse rx='80' ry='40' transform='translate(100,100) scale(0.5)' stroke='red' fill ='green'/> \n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseScaledXYTest() {
            String filename = "ellipseScaledXYTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "\t<line x1='100' y1='100' x2='200' y2='100' stroke='black'/>\n" + "\t<line x1='100' y1='100' x2='100' y2='200' stroke='black'/>\n"
                 + "    <ellipse rx='80' ry='40' transform='translate(100,100)' stroke='black' fill ='yellow'/>\n" + "    <ellipse rx='80' ry='40' transform='translate(100,100) scale(0.5,1.1)' stroke='red' fill ='orange'/> \n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseSkewXTest() {
            String filename = "ellipseSkewXTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <ellipse rx='80' ry='40' transform='translate(100,100)' stroke='black' fill ='yellow'/>\n" + "    <ellipse rx='80' ry='40' transform='translate(100,100) skewX(40)' stroke='red' fill ='orange'/> \n"
                 + "\t<line x1='100' y1='100' x2='200' y2='100' stroke='black'/>\n" + "\t<line x1='100' y1='100' x2='100' y2='200' stroke='black'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }

        /// <exception cref="iText.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        /// <exception cref="System.IO.IOException"/>
        [NUnit.Framework.Test]
        public virtual void EllipseSkewYTest() {
            String filename = "ellipseSkewYTest.pdf";
            PdfDocument doc = new PdfDocument(new PdfWriter(destinationFolder + filename, new WriterProperties().SetCompressionLevel
                (0)));
            doc.AddNewPage();
            String contents = "<svg width='800' height='800'\n" + "     xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">\n"
                 + "    <ellipse rx='80' ry='40' transform='translate(100,100)' stroke='black' fill ='yellow'/>\n" + "    <ellipse rx='80' ry='40' transform='translate(100,100) skewY(20)' stroke='red' fill ='orange'/> \n"
                 + "\t<line x1='100' y1='100' x2='200' y2='100' stroke='black'/>\n" + "\t<line x1='100' y1='100' x2='100' y2='200' stroke='black'/>\n"
                 + "</svg>";
            SvgConverter.DrawOnDocument(contents, doc, 1);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + filename, sourceFolder
                 + "cmp_" + filename, destinationFolder, "diff_"));
        }
    }
}
