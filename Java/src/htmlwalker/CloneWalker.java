/*
 * 
 */
package htmlwalker;

import htmlwalker.core.DocGeneratorWalker;
import htmlwalker.platform.WalkerDocument;

/**
 * This class implements a walker class to produce a clone of existing HTML.
 * 
 * Meant for testing the walker class and to be subclassed for uses where HTML
 * is copied with slight changes.
 * 
 * @author Robert Flores
 */
public class CloneWalker extends DocGeneratorWalker
{
	@Override
    protected <T extends ITag> ITag generateTag(T adapter) { return adapter.clone(this.output.factory(), this.currentTag); }

	/**
	 * Instantiates a new walker cloner.
	 *
	 * @param platform - the platform implementation
	 */
	public CloneWalker(WalkerDocument document) { super(document); }
}
