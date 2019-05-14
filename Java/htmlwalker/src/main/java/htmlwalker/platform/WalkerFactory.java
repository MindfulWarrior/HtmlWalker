/*
 * 
 */
package htmlwalker.platform;

import java.lang.reflect.Constructor;
import java.lang.reflect.InvocationTargetException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import htmlwalker.*;
import htmlwalker.core.EscHandler;
import htmlwalker.tag.base.BaseTag;
import htmlwalker.tag.html.*;
import htmlwalker.tag.util.*;

/**
 * This abstract class is overwritten to provide the factory that generates tag
 * object specific to the platform.
 * 
 * @author Robert Flores
 * @see HtmlWalker.Platform
 */
public abstract class WalkerFactory {
	/**
	 * This is an array of constructor parameters used for getting tag adapter
	 * constructor methods.
	 */
	private static final Class<?>[] ctorArgs = new Class<?>[] { WalkerFactory.class, Object.class };

	/**
	 * This is a map of tag adapter constructors used for creating tag adapter
	 * instances .
	 */
	@SuppressWarnings("serial")
	private static final Map<String, Constructor<?>> map = new HashMap<String, Constructor<?>>() {
		{
			try {
				put("a", TagA.class.getConstructor(ctorArgs));
				put("abbr", TagAbbr.class.getConstructor(ctorArgs));
				put("acronym", TagAcronym.class.getConstructor(ctorArgs));
				put("address", TagAddress.class.getConstructor(ctorArgs));
				put("area", TagArea.class.getConstructor(ctorArgs));
				put("article", TagArticle.class.getConstructor(ctorArgs));
				put("aside", TagAside.class.getConstructor(ctorArgs));
				put("audio", TagAudio.class.getConstructor(ctorArgs));
				put("b", TagB.class.getConstructor(ctorArgs));
				put("base", TagBase.class.getConstructor(ctorArgs));
				put("bdi", TagBdi.class.getConstructor(ctorArgs));
				put("bdo", TagBdo.class.getConstructor(ctorArgs));
				put("big", TagBig.class.getConstructor(ctorArgs));
				put("blockquote", TagBlockquote.class.getConstructor(ctorArgs));
				put("body", TagBody.class.getConstructor(ctorArgs));
				put("br", TagBr.class.getConstructor(ctorArgs));
				put("button", TagButton.class.getConstructor(ctorArgs));
				put("canvas", TagCanvas.class.getConstructor(ctorArgs));
				put("caption", TagCaption.class.getConstructor(ctorArgs));
				put("center", TagCenter.class.getConstructor(ctorArgs));
				put("cite", TagCite.class.getConstructor(ctorArgs));
				put("code", TagCode.class.getConstructor(ctorArgs));
				put("col", TagCol.class.getConstructor(ctorArgs));
				put("colgroup", TagColgroup.class.getConstructor(ctorArgs));
				put("command", TagCommand.class.getConstructor(ctorArgs));
				put("datalist", TagDatalist.class.getConstructor(ctorArgs));
				put("dd", TagDd.class.getConstructor(ctorArgs));
				put("del", TagDel.class.getConstructor(ctorArgs));
				put("details", TagDetails.class.getConstructor(ctorArgs));
				put("dfn", TagDfn.class.getConstructor(ctorArgs));
				put("dialog", TagDialog.class.getConstructor(ctorArgs));
				put("div", TagDiv.class.getConstructor(ctorArgs));
				put("dl", TagDl.class.getConstructor(ctorArgs));
				put("dt", TagDt.class.getConstructor(ctorArgs));
				put("em", TagEm.class.getConstructor(ctorArgs));
				put("embed", TagEmbed.class.getConstructor(ctorArgs));
				put("fieldset", TagFieldset.class.getConstructor(ctorArgs));
				put("figcaption", TagFigcaption.class.getConstructor(ctorArgs));
				put("figure", TagFigure.class.getConstructor(ctorArgs));
				put("font", TagFont.class.getConstructor(ctorArgs));
				put("footer", TagFooter.class.getConstructor(ctorArgs));
				put("form", TagForm.class.getConstructor(ctorArgs));
				put("h1", TagH1.class.getConstructor(ctorArgs));
				put("h2", TagH2.class.getConstructor(ctorArgs));
				put("h3", TagH3.class.getConstructor(ctorArgs));
				put("h4", TagH4.class.getConstructor(ctorArgs));
				put("h5", TagH5.class.getConstructor(ctorArgs));
				put("h6", TagH6.class.getConstructor(ctorArgs));
				put("head", TagHead.class.getConstructor(ctorArgs));
				put("header", TagHeader.class.getConstructor(ctorArgs));
				put("hgroup", TagHgroup.class.getConstructor(ctorArgs));
				put("html", TagHtml.class.getConstructor(ctorArgs));
				put("hr", TagHr.class.getConstructor(ctorArgs));
				put("i", TagI.class.getConstructor(ctorArgs));
				put("iframe", TagIframe.class.getConstructor(ctorArgs));
				put("img", TagImg.class.getConstructor(ctorArgs));
				put("input", TagInput.class.getConstructor(ctorArgs));
				put("kbd", TagKbd.class.getConstructor(ctorArgs));
				put("keygen", TagKeygen.class.getConstructor(ctorArgs));
				put("ins", TagIns.class.getConstructor(ctorArgs));
				put("label", TagLabel.class.getConstructor(ctorArgs));
				put("legend", TagLegend.class.getConstructor(ctorArgs));
				put("li", TagLi.class.getConstructor(ctorArgs));
				put("link", TagLink.class.getConstructor(ctorArgs));
				put("main", TagMain.class.getConstructor(ctorArgs));
				put("map", TagMap.class.getConstructor(ctorArgs));
				put("mark", TagMark.class.getConstructor(ctorArgs));
				put("menu", TagMenu.class.getConstructor(ctorArgs));
				put("menuitem", TagMenuitem.class.getConstructor(ctorArgs));
				put("meta", TagMeta.class.getConstructor(ctorArgs));
				put("meter", TagMeter.class.getConstructor(ctorArgs));
				put("nav", TagNav.class.getConstructor(ctorArgs));
				put("noscript", TagNoscript.class.getConstructor(ctorArgs));
				put("object", TagObject.class.getConstructor(ctorArgs));
				put("ol", TagOl.class.getConstructor(ctorArgs));
				put("optgroup", TagOptgroup.class.getConstructor(ctorArgs));
				put("option", TagOption.class.getConstructor(ctorArgs));
				put("output", TagOutput.class.getConstructor(ctorArgs));
				put("p", TagP.class.getConstructor(ctorArgs));
				put("param", TagParam.class.getConstructor(ctorArgs));
				put("picture", TagPicture.class.getConstructor(ctorArgs));
				put("pre", TagPre.class.getConstructor(ctorArgs));
				put("progress", TagProgress.class.getConstructor(ctorArgs));
				put("q", TagQ.class.getConstructor(ctorArgs));
				put("rp", TagRp.class.getConstructor(ctorArgs));
				put("rt", TagRt.class.getConstructor(ctorArgs));
				put("ruby", TagRuby.class.getConstructor(ctorArgs));
				put("s", TagS.class.getConstructor(ctorArgs));
				put("samp", TagSamp.class.getConstructor(ctorArgs));
				put("script", TagScript.class.getConstructor(ctorArgs));
				put("section", TagSection.class.getConstructor(ctorArgs));
				put("select", TagSelect.class.getConstructor(ctorArgs));
				put("small", TagSmall.class.getConstructor(ctorArgs));
				put("source", TagSource.class.getConstructor(ctorArgs));
				put("span", TagSpan.class.getConstructor(ctorArgs));
				put("strike", TagStrike.class.getConstructor(ctorArgs));
				put("strong", TagStrong.class.getConstructor(ctorArgs));
				put("style", TagStyle.class.getConstructor(ctorArgs));
				put("sub", TagSub.class.getConstructor(ctorArgs));
				put("summary", TagSummary.class.getConstructor(ctorArgs));
				put("sup", TagSup.class.getConstructor(ctorArgs));
				put("table", TagTable.class.getConstructor(ctorArgs));
				put("tbody", TagTbody.class.getConstructor(ctorArgs));
				put("td", TagTd.class.getConstructor(ctorArgs));
				put("textarea", TagTextarea.class.getConstructor(ctorArgs));
				put("tfoot", TagTfoot.class.getConstructor(ctorArgs));
				put("th", TagTh.class.getConstructor(ctorArgs));
				put("thead", TagThead.class.getConstructor(ctorArgs));
				put("time", TagTime.class.getConstructor(ctorArgs));
				put("title", TagTitle.class.getConstructor(ctorArgs));
				put("tr", TagTr.class.getConstructor(ctorArgs));
				put("track", TagTrack.class.getConstructor(ctorArgs));
				put("tt", TagTt.class.getConstructor(ctorArgs));
				put("u", TagU.class.getConstructor(ctorArgs));
				put("ul", TagUl.class.getConstructor(ctorArgs));
				put("var", TagVar.class.getConstructor(ctorArgs));
				put("video", TagVideo.class.getConstructor(ctorArgs));
				put("wbr", TagWbr.class.getConstructor(ctorArgs));
				put("#text", Text.class.getConstructor(ctorArgs));
				put("#entity", Entity.class.getConstructor(ctorArgs));
				put("#eol", Eol.class.getConstructor(ctorArgs));
				put("#comment", Comment.class.getConstructor(ctorArgs));
			} catch (NoSuchMethodException e) {
			}
		};
	};

	public boolean provideEol = false;
	
	public boolean convertToEntities = false;
	
	public abstract WalkerPlatform platform();

	public abstract ITagApi api();
	
	/**
	 * This method creates instances of tag adapters based on the tag object
	 * passed.
	 * 
	 * The <b>ITagApi</b> is used to get the tag name and map it to the
	 * appropriate tag adapter constructor.
	 *
	 * @param owner
	 *            - the owner of the tag object passed.
	 * @param obj
	 *            - the tag object to be housed by the tag adapter.
	 * @return the new tag adapter
	 * @see HtmlWalker.ITagApi
	 */
	public ITag createAdapter(ITag owner, Object obj, String tagName)
	{
		if (tagName == null)
			tagName = api().name(obj);
		
		if (tagName != null)
		{
			BaseTag adapter;
			if (map.containsKey(tagName)) {
				try
				{
					adapter = (BaseTag) map.get(tagName).newInstance(this, obj);
				}
				catch (InstantiationException | IllegalAccessException | IllegalArgumentException | InvocationTargetException e)
				{
					e.printStackTrace();
					return null;
				}
			}
			else
				adapter = new Unknown(this, obj);
			
			if (owner != null)
				adapter.owner(owner);
			return adapter;
		}
		
		return null;
	}

	public ITag createAdapter(ITag owner, Object obj)
	{
		return createAdapter(owner, obj, null);
	}
	
	public Object createText(String text)
	{
		if (convertToEntities)
			return createTextNode(EscHandler.theInstance.escape(text));
		return createTextNode(text);
	}

	public abstract Object cloneTag(Object tag);
	
	/**
	 * This method is overwritten to provide the platform specific way of
	 * creating a walker content object from a tag adapter.
	 *
	 * @param adapter
	 *            - the tag adapter owning the content
	 * @return the walker content
	 */
	public abstract List<Object> createContent(ITag adapter);

	public abstract Object createTextNode(String text);

	public abstract Object createEntityNode(String entity);

	/**
	 * Creates a new <b>&lt;a&gt;</b> tag object.
	 *
	 * @return the <b>&lt;a&gt;</b> tag object
	 */
	public abstract Object createA();

	/**
	 * Creates a new <b>&lt;acronym&gt;</b> tag object.
	 *
	 * @return the <b>&lt;acronym&gt;</b> tag object
	 */
	public abstract Object createAcronym();

	/**
	 * Creates a new <b>&lt;abbr&gt;</b> tag object.
	 *
	 * @return the <b>&lt;abbr&gt;</b> tag object
	 */
	public abstract Object createAbbr();

	/**
	 * Creates a new <b>&lt;address&gt;</b> tag object.
	 *
	 * @return the <b>&lt;address&gt;</b> tag object
	 */
	public abstract Object createAddress();

	// TODO: Maybe can remove all the create{Tag} methods
	
	/**
	 * Creates a new <b>&lt;area&gt;</b> tag object.
	 *
	 * @return the <b>&lt;area&gt;</b> tag object
	 */
	public abstract Object createArea();

	/**
	 * Creates a new <b>&lt;article&gt;</b> tag object.
	 *
	 * @return the <b>&lt;article&gt;</b> tag object
	 */
	public abstract Object createArticle();

	/**
	 * Creates a new <b>&lt;aside&gt;</b> tag object.
	 *
	 * @return the <b>&lt;aside&gt;</b> tag object
	 */
	public abstract Object createAside();

	/**
	 * Creates a new <b>&lt;audio&gt;</b> tag object.
	 *
	 * @return the <b>&lt;audio&gt;</b> tag object
	 */
	public abstract Object createAudio();

	/**
	 * Creates a new <b>&lt;b&gt;</b> tag object.
	 *
	 * @return the <b>&lt;b&gt;</b> tag object
	 */
	public abstract Object createB();

	/**
	 * Creates a new <b>&lt;base&gt;</b> tag object.
	 *
	 * @return the <b>&lt;base&gt;</b> tag object
	 */
	public abstract Object createBase();

	/**
	 * Creates a new <b>&lt;bdi&gt;</b> tag object.
	 *
	 * @return the <b>&lt;bdi&gt;</b> tag object
	 */
	public abstract Object createBdi();

	/**
	 * Creates a new <b>&lt;bdo&gt;</b> tag object.
	 *
	 * @return the <b>&lt;bdo&gt;</b> tag object
	 */
	public abstract Object createBdo();
	
	public abstract Object createBig();

	/**
	 * Creates a new <b>&lt;blockquote&gt;</b> tag object.
	 *
	 * @return the <b>&lt;blockquote&gt;</b> tag object
	 */
	public abstract Object createBlockquote();

	/**
	 * Creates a new <b>&lt;body&gt;</b> tag object.
	 *
	 * @return the <b>&lt;body&gt;</b> tag object
	 */
	public abstract Object createBody();

	/**
	 * Creates a new <b>&lt;br&gt;</b> tag object.
	 *
	 * @return the <b>&lt;br&gt;</b> tag object
	 */
	public abstract Object createBr();

	/**
	 * Creates a new <b>&lt;button&gt;</b> tag object.
	 *
	 * @return the <b>&lt;button&gt;</b> tag object
	 */
	public abstract Object createButton();

	/**
	 * Creates a new <b>&lt;canvas&gt;</b> tag object.
	 *
	 * @return the <b>&lt;canvas&gt;</b> tag object
	 */
	public abstract Object createCanvas();

	/**
	 * Creates a new <b>&lt;caption&gt;</b> tag object.
	 *
	 * @return the <b>&lt;caption&gt;</b> tag object
	 */
	public abstract Object createCaption();

	/**
	 * Creates a new <b>&lt;center&gt;</b> tag object.
	 *
	 * @return the <b>&lt;center&gt;</b> tag object
	 */
	public abstract Object createCenter();

	/**
	 * Creates a new <b>&lt;cite&gt;</b> tag object.
	 *
	 * @return the <b>&lt;cite&gt;</b> tag object
	 */
	public abstract Object createCite();

	/**
	 * Creates a new <b>&lt;code&gt;</b> tag object.
	 *
	 * @return the <b>&lt;code&gt;</b> tag object
	 */
	public abstract Object createCode();

	/**
	 * Creates a new <b>&lt;col&gt;</b> tag object.
	 *
	 * @return the <b>&lt;col&gt;</b> tag object
	 */
	public abstract Object createCol();

	/**
	 * Creates a new <b>&lt;colgroup&gt;</b> tag object.
	 *
	 * @return the <b>&lt;colgroup&gt;</b> tag object
	 */
	public abstract Object createColgroup();

	/**
	 * Creates a new <b>&lt;command&gt;</b> tag object.
	 *
	 * @return the <b>&lt;command&gt;</b> tag object
	 */
	public abstract Object createCommand();

	/**
	 * Creates a new <b>&lt;datalist&gt;</b> tag object.
	 *
	 * @return the <b>&lt;datalist&gt;</b> tag object
	 */
	public abstract Object createDatalist();

	/**
	 * Creates a new <b>&lt;dd&gt;</b> tag object.
	 *
	 * @return the <b>&lt;dd&gt;</b> tag object
	 */
	public abstract Object createDd();

	/**
	 * Creates a new <b>&lt;del&gt;</b> tag object.
	 *
	 * @return the <b>&lt;del&gt;</b> tag object
	 */
	public abstract Object createDel();

	/**
	 * Creates a new <b>&lt;details&gt;</b> tag object.
	 *
	 * @return the <b>&lt;details&gt;</b> tag object
	 */
	public abstract Object createDetails();

	/**
	 * Creates a new <b>&lt;dfn&gt;</b> tag object.
	 *
	 * @return the <b>&lt;dfn&gt;</b> tag object
	 */
	public abstract Object createDfn();

	/**
	 * Creates a new <b>&lt;dialog&gt;</b> tag object.
	 *
	 * @return the <b>&lt;dialog&gt;</b> tag object
	 */
	public abstract Object createDialog();

	/**
	 * Creates a new <b>&lt;div&gt;</b> tag object.
	 *
	 * @return the <b>&lt;div&gt;</b> tag object
	 */
	public abstract Object createDiv();

	/**
	 * Creates a new <b>&lt;dl&gt;</b> tag object.
	 *
	 * @return the <b>&lt;dl&gt;</b> tag object
	 */
	public abstract Object createDl();

	/**
	 * Creates a new <b>&lt;dt&gt;</b> tag object.
	 *
	 * @return the <b>&lt;dt&gt;</b> tag object
	 */
	public abstract Object createDt();

	/**
	 * Creates a new <b>&lt;em&gt;</b> tag object.
	 *
	 * @return the <b>&lt;em&gt;</b> tag object
	 */
	public abstract Object createEm();

	/**
	 * Creates a new <b>&lt;embed&gt;</b> tag object.
	 *
	 * @return the <b>&lt;embed&gt;</b> tag object
	 */
	public abstract Object createEmbed();

	/**
	 * Creates a new <b>&lt;fieldset&gt;</b> tag object.
	 *
	 * @return the <b>&lt;fieldset&gt;</b> tag object
	 */
	public abstract Object createFieldset();

	/**
	 * Creates a new <b>&lt;figcaption&gt;</b> tag object.
	 *
	 * @return the <b>&lt;figcaption&gt;</b> tag object
	 */
	public abstract Object createFigcaption();

	/**
	 * Creates a new <b>&lt;figure&gt;</b> tag object.
	 *
	 * @return the <b>&lt;figure&gt;</b> tag object
	 */
	public abstract Object createFigure();

	/**
	 * Creates a new <b>&lt;font&gt;</b> tag object.
	 *
	 * @return the <b>&lt;font&gt;</b> tag object
	 */
	public abstract Object createFont();

	/**
	 * Creates a new <b>&lt;footer&gt;</b> tag object.
	 *
	 * @return the <b>&lt;footer&gt;</b> tag object
	 */
	public abstract Object createFooter();

	/**
	 * Creates a new <b>&lt;form&gt;</b> tag object.
	 *
	 * @return the <b>&lt;form&gt;</b> tag object
	 */
	public abstract Object createForm();

	/**
	 * Creates a new <b>&lt;h1&gt;</b> tag object.
	 *
	 * @return the <b>&lt;h1&gt;</b> tag object
	 */
	public abstract Object createH1();

	/**
	 * Creates a new <b>&lt;h2&gt;</b> tag object.
	 *
	 * @return the <b>&lt;h2&gt;</b> tag object
	 */
	public abstract Object createH2();

	/**
	 * Creates a new <b>&lt;h3&gt;</b> tag object.
	 *
	 * @return the <b>&lt;h3&gt;</b> tag object
	 */
	public abstract Object createH3();

	/**
	 * Creates a new <b>&lt;h4&gt;</b> tag object.
	 *
	 * @return the <b>&lt;h4&gt;</b> tag object
	 */
	public abstract Object createH4();

	/**
	 * Creates a new <b>&lt;h5&gt;</b> tag object.
	 *
	 * @return the <b>&lt;h5&gt;</b> tag object
	 */
	public abstract Object createH5();

	/**
	 * Creates a new <b>&lt;h6&gt;</b> tag object.
	 *
	 * @return the <b>&lt;h6&gt;</b> tag object
	 */
	public abstract Object createH6();

	/**
	 * Creates a new <b>&lt;hr&gt;</b> tag object.
	 *
	 * @return the <b>&lt;hr&gt;</b> tag object
	 */
	public abstract Object createHr();

	/**
	 * Creates a new <b>&lt;head&gt;</b> tag object.
	 *
	 * @return the <b>&lt;head&gt;</b> tag object
	 */
	public abstract Object createHead();

	/**
	 * Creates a new <b>&lt;header&gt;</b> tag object.
	 *
	 * @return the <b>&lt;header&gt;</b> tag object
	 */
	public abstract Object createHeader();

	/**
	 * Creates a new <b>&lt;hgroup&gt;</b> tag object.
	 *
	 * @return the <b>&lt;hgroup&gt;</b> tag object
	 */
	public abstract Object createHgroup();

	/**
	 * Creates a new <b>&lt;html&gt;</b> tag object.
	 *
	 * @return the <b>&lt;html&gt;</b> tag object
	 */
	public abstract Object createHtml();

	/**
	 * Creates a new <b>&lt;i&gt;</b> tag object.
	 *
	 * @return the <b>&lt;i&gt;</b> tag object
	 */
	public abstract Object createI();

	/**
	 * Creates a new <b>&lt;iframe&gt;</b> tag object.
	 *
	 * @return the <b>&lt;iframe&gt;</b> tag object
	 */
	public abstract Object createIframe();

	/**
	 * Creates a new <b>&lt;img&gt;</b> tag object.
	 *
	 * @return the <b>&lt;img&gt;</b> tag object
	 */
	public abstract Object createImg();

	/**
	 * Creates a new <b>&lt;input&gt;</b> tag object.
	 *
	 * @return the <b>&lt;input&gt;</b> tag object
	 */
	public abstract Object createInput();

	/**
	 * Creates a new <b>&lt;ins&gt;</b> tag object.
	 *
	 * @return the <b>&lt;ins&gt;</b> tag object
	 */
	public abstract Object createIns();

	/**
	 * Creates a new <b>&lt;keygen&gt;</b> tag object.
	 *
	 * @return the <b>&lt;keygen&gt;</b> tag object
	 */
	public abstract Object createKeygen();

	/**
	 * Creates a new <b>&lt;kbd&gt;</b> tag object.
	 *
	 * @return the <b>&lt;kbd&gt;</b> tag object
	 */
	public abstract Object createKbd();

	/**
	 * Creates a new <b>&lt;label&gt;</b> tag object.
	 *
	 * @return the <b>&lt;label&gt;</b> tag object
	 */
	public abstract Object createLabel();

	/**
	 * Creates a new <b>&lt;legend&gt;</b> tag object.
	 *
	 * @return the <b>&lt;legend&gt;</b> tag object
	 */
	public abstract Object createLegend();

	/**
	 * Creates a new <b>&lt;li&gt;</b> tag object.
	 *
	 * @return the <b>&lt;li&gt;</b> tag object
	 */
	public abstract Object createLi();

	/**
	 * Creates a new <b>&lt;link&gt;</b> tag object.
	 *
	 * @return the <b>&lt;link&gt;</b> tag object
	 */
	public abstract Object createLink();

	/**
	 * Creates a new <b>&lt;main&gt;</b> tag object.
	 *
	 * @return the <b>&lt;main&gt;</b> tag object
	 */
	public abstract Object createMain();

	/**
	 * Creates a new <b>&lt;map&gt;</b> tag object.
	 *
	 * @return the <b>&lt;map&gt;</b> tag object
	 */
	public abstract Object createMap();

	/**
	 * Creates a new <b>&lt;mark&gt;</b> tag object.
	 *
	 * @return the <b>&lt;mark&gt;</b> tag object
	 */
	public abstract Object createMark();

	/**
	 * Creates a new <b>&lt;menu&gt;</b> tag object.
	 *
	 * @return the <b>&lt;menu&gt;</b> tag object
	 */
	public abstract Object createMenu();

	/**
	 * Creates a new <b>&lt;menuitem&gt;</b> tag object.
	 *
	 * @return the <b>&lt;menuitem&gt;</b> tag object
	 */
	public abstract Object createMenuitem();

	/**
	 * Creates a new <b>&lt;meta&gt;</b> tag object.
	 *
	 * @return the <b>&lt;meta&gt;</b> tag object
	 */
	public abstract Object createMeta();

	/**
	 * Creates a new <b>&lt;meter&gt;</b> tag object.
	 *
	 * @return the <b>&lt;meter&gt;</b> tag object
	 */
	public abstract Object createMeter();

	/**
	 * Creates a new <b>&lt;nav&gt;</b> tag object.
	 *
	 * @return the <b>&lt;nav&gt;</b> tag object
	 */
	public abstract Object createNav();

	/**
	 * Creates a new <b>&lt;noscript&gt;</b> tag object.
	 *
	 * @return the <b>&lt;noscript&gt;</b> tag object
	 */
	public abstract Object createNoscript();

	/**
	 * Creates a new <b>&lt;object&gt;</b> tag object.
	 *
	 * @return the <b>&lt;object&gt;</b> tag object
	 */
	public abstract Object createObject();

	/**
	 * Creates a new <b>&lt;ol&gt;</b> tag object.
	 *
	 * @return the <b>&lt;ol&gt;</b> tag object
	 */
	public abstract Object createOl();

	/**
	 * Creates a new <b>&lt;optgroup&gt;</b> tag object.
	 *
	 * @return the <b>&lt;optgroup&gt;</b> tag object
	 */
	public abstract Object createOptgroup();

	/**
	 * Creates a new <b>&lt;option&gt;</b> tag object.
	 *
	 * @return the <b>&lt;option&gt;</b> tag object
	 */
	public abstract Object createOption();

	/**
	 * Creates a new <b>&lt;output&gt;</b> tag object.
	 *
	 * @return the <b>&lt;output&gt;</b> tag object
	 */
	public abstract Object createOutput();

	/**
	 * Creates a new <b>&lt;p&gt;</b> tag object.
	 *
	 * @return the <b>&lt;p&gt;</b> tag object
	 */
	public abstract Object createP();

	/**
	 * Creates a new <b>&lt;param&gt;</b> tag object.
	 *
	 * @return the <b>&lt;param&gt;</b> tag object
	 */
	public abstract Object createParam();

	/**
	 * Creates a new <b>&lt;picture&gt;</b> tag object.
	 *
	 * @return the <b>&lt;picture&gt;</b> tag object
	 */
	public abstract Object createPicture();

	/**
	 * Creates a new <b>&lt;pre&gt;</b> tag object.
	 *
	 * @return the <b>&lt;pre&gt;</b> tag object
	 */
	public abstract Object createPre();

	/**
	 * Creates a new <b>&lt;progress&gt;</b> tag object.
	 *
	 * @return the <b>&lt;progress&gt;</b> tag object
	 */
	public abstract Object createProgress();

	/**
	 * Creates a new <b>&lt;q&gt;</b> tag object.
	 *
	 * @return the <b>&lt;q&gt;</b> tag object
	 */
	public abstract Object createQ();

	/**
	 * Creates a new <b>&lt;rp&gt;</b> tag object.
	 *
	 * @return the <b>&lt;rp&gt;</b> tag object
	 */
	public abstract Object createRp();

	/**
	 * Creates a new <b>&lt;rt&gt;</b> tag object.
	 *
	 * @return the <b>&lt;rt&gt;</b> tag object
	 */
	public abstract Object createRt();

	/**
	 * Creates a new <b>&lt;ruby&gt;</b> tag object.
	 *
	 * @return the <b>&lt;ruby&gt;</b> tag object
	 */
	public abstract Object createRuby();

	/**
	 * Creates a new <b>&lt;s&gt;</b> tag object.
	 *
	 * @return the <b>&lt;s&gt;</b> tag object
	 */
	public abstract Object createS();

	/**
	 * Creates a new <b>&lt;samp&gt;</b> tag object.
	 *
	 * @return the <b>&lt;samp&gt;</b> tag object
	 */
	public abstract Object createSamp();

	/**
	 * Creates a new <b>&lt;script&gt;</b> tag object.
	 *
	 * @return the <b>&lt;script&gt;</b> tag object
	 */
	public abstract Object createScript();

	/**
	 * Creates a new <b>&lt;section&gt;</b> tag object.
	 *
	 * @return the <b>&lt;section&gt;</b> tag object
	 */
	public abstract Object createSection();

	/**
	 * Creates a new <b>&lt;select&gt;</b> tag object.
	 *
	 * @return the <b>&lt;select&gt;</b> tag object
	 */
	public abstract Object createSelect();

	/**
	 * Creates a new <b>&lt;small&gt;</b> tag object.
	 *
	 * @return the <b>&lt;small&gt;</b> tag object
	 */
	public abstract Object createSmall();

	/**
	 * Creates a new <b>&lt;source&gt;</b> tag object.
	 *
	 * @return the <b>&lt;source&gt;</b> tag object
	 */
	public abstract Object createSource();

	/**
	 * Creates a new <b>&lt;span&gt;</b> tag object.
	 *
	 * @return the <b>&lt;span&gt;</b> tag object
	 */
	public abstract Object createSpan();

	/**
	 * Creates a new <b>&lt;strike&gt;</b> tag object.
	 *
	 * @return the <b>&lt;strike&gt;</b> tag object
	 */
	public abstract Object createStrike();

	/**
	 * Creates a new <b>&lt;strong&gt;</b> tag object.
	 *
	 * @return the <b>&lt;strong&gt;</b> tag object
	 */
	public abstract Object createStrong();

	/**
	 * Creates a new <b>&lt;style&gt;</b> tag object.
	 *
	 * @return the <b>&lt;style&gt;</b> tag object
	 */
	public abstract Object createStyle();

	/**
	 * Creates a new <b>&lt;sub&gt;</b> tag object.
	 *
	 * @return the <b>&lt;sub&gt;</b> tag object
	 */
	public abstract Object createSub();

	/**
	 * Creates a new <b>&lt;summary&gt;</b> tag object.
	 *
	 * @return the <b>&lt;summary&gt;</b> tag object
	 */
	public abstract Object createSummary();

	/**
	 * Creates a new <b>&lt;sup&gt;</b> tag object.
	 *
	 * @return the <b>&lt;sup&gt;</b> tag object
	 */
	public abstract Object createSup();

	/**
	 * Creates a new <b>&lt;table&gt;</b> tag object.
	 *
	 * @return the <b>&lt;table&gt;</b> tag object
	 */
	public abstract Object createTable();

	/**
	 * Creates a new <b>&lt;tbody&gt;</b> tag object.
	 *
	 * @return the <b>&lt;tbody&gt;</b> tag object
	 */
	public abstract Object createTbody();

	/**
	 * Creates a new <b>&lt;td&gt;</b> tag object.
	 *
	 * @return the <b>&lt;td&gt;</b> tag object
	 */
	public abstract Object createTd();

	/**
	 * Creates a new <b>&lt;textarea&gt;</b> tag object.
	 *
	 * @return the <b>&lt;textarea&gt;</b> tag object
	 */
	public abstract Object createTextarea();

	/**
	 * Creates a new <b>&lt;tfoot&gt;</b> tag object.
	 *
	 * @return the <b>&lt;tfoot&gt;</b> tag object
	 */
	public abstract Object createTfoot();

	/**
	 * Creates a new <b>&lt;th&gt;</b> tag object.
	 *
	 * @return the <b>&lt;th&gt;</b> tag object
	 */
	public abstract Object createTh();

	/**
	 * Creates a new <b>&lt;thead&gt;</b> tag object.
	 *
	 * @return the <b>&lt;thead&gt;</b> tag object
	 */
	public abstract Object createThead();

	/**
	 * Creates a new <b>&lt;time&gt;</b> tag object.
	 *
	 * @return the <b>&lt;time&gt;</b> tag object
	 */
	public abstract Object createTime();

	/**
	 * Creates a new <b>&lt;title&gt;</b> tag object.
	 *
	 * @return the <b>&lt;title&gt;</b> tag object
	 */
	public abstract Object createTitle();

	/**
	 * Creates a new <b>&lt;tr&gt;</b> tag object.
	 *
	 * @return the <b>&lt;tr&gt;</b> tag object
	 */
	public abstract Object createTr();

	/**
	 * Creates a new <b>&lt;track&gt;</b> tag object.
	 *
	 * @return the <b>&lt;track&gt;</b> tag object
	 */
	public abstract Object createTrack();

	/**
	 * Creates a new <b>&lt;tt&gt;</b> tag object.
	 *
	 * @return the <b>&lt;tt&gt;</b> tag object
	 */
	public abstract Object createTt();

	/**
	 * Creates a new <b>&lt;u&gt;</b> tag object.
	 *
	 * @return the <b>&lt;u&gt;</b> tag object
	 */
	public abstract Object createU();

	/**
	 * Creates a new <b>&lt;ul&gt;</b> tag object.
	 *
	 * @return the <b>&lt;ul&gt;</b> tag object
	 */
	public abstract Object createUl();

	/**
	 * Creates a new <b>&lt;var&gt;</b> tag object.
	 *
	 * @return the <b>&lt;var&gt;</b> tag object
	 */
	public abstract Object createVar();

	/**
	 * Creates a new <b>&lt;video&gt;</b> tag object.
	 *
	 * @return the <b>&lt;video&gt;</b> tag object
	 */
	public abstract Object createVideo();

	/**
	 * Creates a new <b>&lt;wbr&gt;</b> tag object.
	 *
	 * @return the <b>&lt;wbr&gt;</b> tag object
	 */
	public abstract Object createWbr();

}
