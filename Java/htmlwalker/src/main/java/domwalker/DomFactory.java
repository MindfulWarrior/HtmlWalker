package domwalker;

import java.util.List;

import htmlwalker.ITag;
import htmlwalker.platform.*;

public abstract class DomFactory<A extends DomApi<D>, D> extends WalkerFactory
{	
	private final WalkerPlatform platform;
	
	protected final A dapi;
	
	protected D dom;
	
	protected DomFactory(A dapi, D dom, WalkerPlatform platform)
	{
		this.dapi = dapi;
		this.dom = dom;
		this.platform = platform;
	}
	
	public abstract void close();
	
	@Override
	public WalkerPlatform platform() { return this.platform; }
	
	@Override
	public Object createTextNode(String text) { return dapi.createTextNode(dom, text); }
	
	@Override
	public Object createEntityNode(String entity) { return dapi.createTextNode(dom, entity); }

	@Override
	public List<Object> createContent(ITag adapter) { return dapi.getContent(dom, adapter); }
	
    @Override
    public Object createA() { return dapi.createElement(dom, "a"); }

    @Override
    public Object createAbbr() { return dapi.createElement(dom, "abbr"); }

	@Override
	public Object createAcronym() { return dapi.createElement(dom, "acronym"); }

    @Override
    public Object createAddress() { return dapi.createElement(dom, "address"); }

    @Override
    public Object createArea() { return dapi.createElement(dom, "area"); }

    @Override
    public Object createArticle() { return dapi.createElement(dom, "article"); }

    @Override
    public Object createAside() { return dapi.createElement(dom, "aside"); }

    @Override
    public Object createAudio() { return dapi.createElement(dom, "audio"); }

    @Override
    public Object createB() { return dapi.createElement(dom, "b"); }

    @Override
    public Object createBase() { return dapi.createElement(dom, "base"); }

    @Override
    public Object createBdi() { return dapi.createElement(dom, "bdi"); }

    @Override
    public Object createBig() { return dapi.createElement(dom, "big"); }

    @Override
    public Object createBdo() { return dapi.createElement(dom, "bdo"); }

    @Override
    public Object createBlockquote() { return dapi.createElement(dom, "blockquote"); }

    @Override
    public Object createBody() { return dapi.createElement(dom, "body"); }

    @Override
    public Object createBr() { return dapi.createElement(dom, "br"); }

    @Override
    public Object createButton() { return dapi.createElement(dom, "button"); }

    @Override
    public Object createCanvas() { return dapi.createElement(dom, "canvas"); }

    @Override
    public Object createCaption() { return dapi.createElement(dom, "caption"); }

    @Override
    public Object createCenter() { return dapi.createElement(dom, "center"); }

    @Override
    public Object createCite() { return dapi.createElement(dom, "cite"); }

    @Override
    public Object createCode() { return dapi.createElement(dom, "code"); }

    @Override
    public Object createCol() { return dapi.createElement(dom, "col"); }

    @Override
    public Object createColgroup() { return dapi.createElement(dom, "colgroup"); }

    @Override
    public Object createCommand() { return dapi.createElement(dom, "command"); }

    @Override
    public Object createDatalist() { return dapi.createElement(dom, "datalist"); }

    @Override
    public Object createDd() { return dapi.createElement(dom, "dd"); }

    @Override
    public Object createDel() { return dapi.createElement(dom, "del"); }

    @Override
    public Object createDetails() { return dapi.createElement(dom, "details"); }

    @Override
    public Object createDialog() { return dapi.createElement(dom, "dialog"); }

    @Override
    public Object createDiv() { return dapi.createElement(dom, "div"); }

    @Override
    public Object createDfn() { return dapi.createElement(dom, "dfn"); }

    @Override
    public Object createDl() { return dapi.createElement(dom, "dl"); }

    @Override
    public Object createDt() { return dapi.createElement(dom, "dt"); }

    @Override
    public Object createEm() { return dapi.createElement(dom, "em"); }

    @Override
    public Object createEmbed() { return dapi.createElement(dom, "embed"); }

    @Override
    public Object createFigcaption() { return dapi.createElement(dom, "figcaption"); }

    @Override
    public Object createFigure() { return dapi.createElement(dom, "figure"); }

    @Override
    public Object createFieldset() { return dapi.createElement(dom, "fieldset"); }

    @Override
    public Object createFooter() { return dapi.createElement(dom, "footer"); }

    @Override
    public Object createFont() { return dapi.createElement(dom, "font"); }

    @Override
    public Object createForm() { return dapi.createElement(dom, "form"); }

    @Override
    public Object createH1() { return dapi.createElement(dom, "h1"); }

    @Override
    public Object createH2() { return dapi.createElement(dom, "h2"); }

    @Override
    public Object createH3() { return dapi.createElement(dom, "h3"); }

    @Override
    public Object createH4() { return dapi.createElement(dom, "h4"); }

    @Override
    public Object createH5() { return dapi.createElement(dom, "h5"); }

    @Override
    public Object createH6() { return dapi.createElement(dom, "h6"); }

    @Override
    public Object createHead() { return dapi.createElement(dom, "head"); }

    @Override
    public Object createHeader() { return dapi.createElement(dom, "header"); }

    @Override
    public Object createHgroup() { return dapi.createElement(dom, "hgroup"); }

    @Override
    public Object createHtml() {
        Object tag = dapi.htmlElement(dom);
        if (tag == null)
            tag = dapi.createElement(dom, "html");
        return tag;
    }

    @Override
    public Object createHr() { return dapi.createElement(dom, "hr"); }

    @Override
    public Object createI() { return dapi.createElement(dom, "i"); }

    @Override
    public Object createIframe() { return dapi.createElement(dom, "iframe"); }

    @Override
    public Object createImg() { return dapi.createElement(dom, "img"); }

    @Override
    public Object createInput() { return dapi.createElement(dom, "input"); }

    @Override
    public Object createIns() { return dapi.createElement(dom, "ins"); }

    @Override
    public Object createKbd() { return dapi.createElement(dom, "kbd"); }

    @Override
    public Object createKeygen() { return dapi.createElement(dom, "keygen"); }

    @Override
    public Object createLabel() { return dapi.createElement(dom, "label"); }

    @Override
    public Object createLegend() { return dapi.createElement(dom, "legend"); }

    @Override
    public Object createLi() { return dapi.createElement(dom, "li"); }

    @Override
    public Object createLink() { return dapi.createElement(dom, "link"); }

    @Override
    public Object createMain() { return dapi.createElement(dom, "main"); }

    @Override
    public Object createMap() { return dapi.createElement(dom, "map"); }

    @Override
    public Object createMark() { return dapi.createElement(dom, "mark"); }

    @Override
    public Object createMenu() { return dapi.createElement(dom, "menu"); }

	@Override
	public Object createMenuitem() { return dapi.createElement(dom, "menuitem"); }

    @Override
    public Object createMeta() { return dapi.createElement(dom, "meta"); }

    @Override
    public Object createMeter() { return dapi.createElement(dom, "meter"); }

    @Override
    public Object createNav() { return dapi.createElement(dom, "nav"); }

    @Override
    public Object createNoscript() { return dapi.createElement(dom, "noscript"); }

    @Override
    public Object createObject() { return dapi.createElement(dom, "object"); }

    @Override
    public Object createOl() { return dapi.createElement(dom, "ol"); }

    @Override
    public Object createOptgroup() { return dapi.createElement(dom, "optgroup"); }

    @Override
    public Object createOption() { return dapi.createElement(dom, "option"); }

    @Override
    public Object createOutput() { return dapi.createElement(dom, "output"); }

    @Override
    public Object createP() { return dapi.createElement(dom, "p"); }

    @Override
    public Object createParam() { return dapi.createElement(dom, "param"); }

	@Override
	public Object createPicture() { return dapi.createElement(dom, "picture"); }

    @Override
    public Object createPre() { return dapi.createElement(dom, "pre"); }

    @Override
    public Object createProgress() { return dapi.createElement(dom, "progress"); }

    @Override
    public Object createQ() { return dapi.createElement(dom, "q"); }

    @Override
    public Object createRp() { return dapi.createElement(dom, "rp"); }

    @Override
    public Object createRt() { return dapi.createElement(dom, "rt"); }

    @Override
    public Object createRuby() { return dapi.createElement(dom, "ruby"); }

    @Override
    public Object createS() { return dapi.createElement(dom, "s"); }

    @Override
    public Object createSamp() { return dapi.createElement(dom, "samp"); }

    @Override
    public Object createScript() { return dapi.createElement(dom, "script"); }

    @Override
    public Object createSection() { return dapi.createElement(dom, "section"); }

    @Override
    public Object createSelect() { return dapi.createElement(dom, "select"); }

    @Override
    public Object createSmall() { return dapi.createElement(dom, "small"); }

    @Override
    public Object createSource() { return dapi.createElement(dom, "source"); }

    @Override
    public Object createSpan() { return dapi.createElement(dom, "span"); }

    @Override
    public Object createStrike() { return dapi.createElement(dom, "strike"); }

    @Override
    public Object createStrong() { return dapi.createElement(dom, "strong"); }

    @Override
    public Object createStyle() { return dapi.createElement(dom, "style"); }

    @Override
    public Object createSub() { return dapi.createElement(dom, "sub"); }

    @Override
    public Object createSummary() { return dapi.createElement(dom, "summary"); }

    @Override
    public Object createSup() { return dapi.createElement(dom, "sup"); }

    @Override
    public Object createTable() { return dapi.createElement(dom, "table"); }

    @Override
    public Object createTbody() { return dapi.createElement(dom, "tbody"); }

    @Override
    public Object createTd() { return dapi.createElement(dom, "td"); }

    @Override
    public Object createTextarea() { return dapi.createElement(dom, "textarea"); }

    @Override
    public Object createTfoot() { return dapi.createElement(dom, "tfoot"); }

    @Override
    public Object createTh() { return dapi.createElement(dom, "th"); }

    @Override
    public Object createThead() { return dapi.createElement(dom, "thead"); }

    @Override
    public Object createTime() { return dapi.createElement(dom, "time"); }

    @Override
    public Object createTitle() { return dapi.createElement(dom, "title"); }

    @Override
    public Object createTr() { return dapi.createElement(dom, "tr"); }

    @Override
    public Object createTrack() { return dapi.createElement(dom, "track"); }

	@Override
	public Object createTt() { return dapi.createElement(dom, "tt"); }

    @Override
    public Object createU() { return dapi.createElement(dom, "u"); }

    @Override
    public Object createUl() { return dapi.createElement(dom, "ul"); }

    @Override
    public Object createVar() { return dapi.createElement(dom, "var"); }

    @Override
    public Object createVideo() { return dapi.createElement(dom, "video"); }

    @Override
    public Object createWbr() { return dapi.createElement(dom, "wbr"); }
	
}
