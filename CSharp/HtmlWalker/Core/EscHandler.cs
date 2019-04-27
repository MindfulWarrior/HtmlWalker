using HtmlWalker.Platform;
using System;
using System.Collections.Generic;

namespace HtmlWalker.Core
{
    /// <summary>
    ///   The HTML/XML parser will often translate the entities, which is
    ///   what is not wanted when the HTML is walked. Instead, the entities need to be
    ///   preserved for other kinds of processing that will occur later.
    ///
    ///   This singleton is used to preserve the entities which would be consumed
    ///   during HTML/XML processing, otherwise.
    /// </summary>
    /// <author>Robert R Flores</author>
    public class EscHandler
    {
        private EscHandler() { }

        /// <summary>
        ///   Access to the singleton
        /// </summary>
	    public static readonly EscHandler Instance = new EscHandler();

        private static readonly Dictionary<int, string> EscChars = new Dictionary<int, string>();

        static EscHandler()
        {
            //EscChars.Add((int)'\"', "&quot;");
            //EscChars.Add((int)'\'', "&apos;");
            EscChars.Add((int)'<', "&lt;");
            EscChars.Add((int)'>', "&gt;");

            EscChars.Add(128, "&euro;");
            EscChars.Add(130, "&sbquo;");
            EscChars.Add(131, "&fnof;");
            EscChars.Add(132, "&bdquo;");
            EscChars.Add(133, "&hellip;");
            EscChars.Add(134, "&dagger;");
            EscChars.Add(135, "&Dagger;");
            EscChars.Add(136, "&circ;");
            EscChars.Add(137, "&permil;");
            EscChars.Add(138, "&Scaron;");
            EscChars.Add(139, "&lsaquo;");
            EscChars.Add(140, "&OElig;");
            EscChars.Add(142, "&Zcaron;");
            EscChars.Add(145, "&lsquo;");
            EscChars.Add(146, "&rsquo;");
            EscChars.Add(147, "&ldquo;");
            EscChars.Add(148, "&rdquo;");
            EscChars.Add(149, "&bull;");
            EscChars.Add(150, "&ndash;");
            EscChars.Add(151, "&mdash;");
            EscChars.Add(152, "&tilde;");
            EscChars.Add(153, "&trade;");
            EscChars.Add(154, "&scaron;");
            EscChars.Add(155, "&rsaquo;");
            EscChars.Add(156, "&oelig;");
            EscChars.Add(158, "&zcaron;");
            EscChars.Add(159, "&Yuml;");
            EscChars.Add(160, "&nbsp;");
            EscChars.Add(161, "&iexcl;");
            EscChars.Add(162, "&cent;");
            EscChars.Add(163, "&pound;");
            EscChars.Add(164, "&curren;");
            EscChars.Add(165, "&yen;");
            EscChars.Add(166, "&brvbar;");
            EscChars.Add(167, "&sect;");
            EscChars.Add(168, "&uml;");
            EscChars.Add(169, "&copy;");
            EscChars.Add(170, "&ordf;");
            EscChars.Add(171, "&laquo;");
            EscChars.Add(172, "&not;");
            EscChars.Add(173, "&shy;");
            EscChars.Add(174, "&reg;");
            EscChars.Add(175, "&macr;");
            EscChars.Add(176, "&deg;");
            EscChars.Add(177, "&plusmn;");
            EscChars.Add(178, "&sup2;");
            EscChars.Add(179, "&sup3;");
            EscChars.Add(180, "&acute;");
            EscChars.Add(181, "&micro;");
            EscChars.Add(182, "&para;");
            EscChars.Add(183, "&middot;");
            EscChars.Add(184, "&cedil;");
            EscChars.Add(185, "&sup1;");
            EscChars.Add(186, "&ordm;");
            EscChars.Add(187, "&raquo;");
            EscChars.Add(188, "&frac14;");
            EscChars.Add(189, "&frac12;");
            EscChars.Add(190, "&frac34;");
            EscChars.Add(191, "&iquest;");
            EscChars.Add(192, "&Agrave;");
            EscChars.Add(193, "&Aacute;");
            EscChars.Add(194, "&Acirc;");
            EscChars.Add(195, "&Atilde;");
            EscChars.Add(196, "&Auml;");
            EscChars.Add(197, "&Aring;");
            EscChars.Add(198, "&AElig;");
            EscChars.Add(199, "&Ccedil;");
            EscChars.Add(200, "&Egrave;");
            EscChars.Add(201, "&Eacute;");
            EscChars.Add(202, "&Ecirc;");
            EscChars.Add(203, "&Euml;");
            EscChars.Add(204, "&Igrave;");
            EscChars.Add(205, "&Iacute;");
            EscChars.Add(206, "&Icirc;");
            EscChars.Add(207, "&Iuml;");
            EscChars.Add(208, "&ETH;");
            EscChars.Add(209, "&Ntilde;");
            EscChars.Add(210, "&Ograve;");
            EscChars.Add(211, "&Oacute;");
            EscChars.Add(212, "&Ocirc;");
            EscChars.Add(213, "&Otilde;");
            EscChars.Add(214, "&Ouml;");
            EscChars.Add(215, "&times;");
            EscChars.Add(216, "&Oslash;");
            EscChars.Add(217, "&Ugrave;");
            EscChars.Add(218, "&Uacute;");
            EscChars.Add(219, "&Ucirc;");
            EscChars.Add(220, "&Uuml;");
            EscChars.Add(221, "&Yacute;");
            EscChars.Add(222, "&THORN;");
            EscChars.Add(223, "&szlig;");
            EscChars.Add(224, "&agrave;");
            EscChars.Add(225, "&aacute;");
            EscChars.Add(226, "&acirc;");
            EscChars.Add(227, "&atilde;");
            EscChars.Add(228, "&auml;");
            EscChars.Add(229, "&aring;");
            EscChars.Add(230, "&aelig;");
            EscChars.Add(231, "&ccedil;");
            EscChars.Add(232, "&egrave;");
            EscChars.Add(233, "&eacute;");
            EscChars.Add(234, "&ecirc;");
            EscChars.Add(235, "&euml;");
            EscChars.Add(236, "&igrave;");
            EscChars.Add(237, "&iacute;");
            EscChars.Add(238, "&icirc;");
            EscChars.Add(239, "&iuml;");
            EscChars.Add(240, "&eth;");
            EscChars.Add(241, "&ntilde;");
            EscChars.Add(242, "&ograve;");
            EscChars.Add(243, "&oacute;");
            EscChars.Add(244, "&ocirc;");
            EscChars.Add(245, "&otilde;");
            EscChars.Add(246, "&ouml;");
            EscChars.Add(247, "&divide;");
            EscChars.Add(248, "&oslash;");
            EscChars.Add(249, "&ugrave;");
            EscChars.Add(250, "&uacute;");
            EscChars.Add(251, "&ucirc;");
            EscChars.Add(252, "&uuml;");
            EscChars.Add(253, "&yacute;");
            EscChars.Add(254, "&thorn;");
            EscChars.Add(255, "&yuml;");

            EscChars.Add(338, "&OElig;");
            EscChars.Add(339, "&oelig;");
            EscChars.Add(352, "&Scaron;");
            EscChars.Add(353, "&scaron;");
            EscChars.Add(376, "&Yuml;");
            EscChars.Add(402, "&fnof;");
            EscChars.Add(710, "&circ;");
            EscChars.Add(732, "&tilde;");
            EscChars.Add(913, "&Alpha;");
            EscChars.Add(914, "&Beta;");
            EscChars.Add(915, "&Gamma;");
            EscChars.Add(916, "&Delta;");
            EscChars.Add(917, "&Epsilon;");
            EscChars.Add(918, "&Zeta;");
            EscChars.Add(919, "&Eta;");
            EscChars.Add(920, "&Theta;");
            EscChars.Add(921, "&Iota;");
            EscChars.Add(922, "&Kappa;");
            EscChars.Add(923, "&Lambda;");
            EscChars.Add(924, "&Mu;");
            EscChars.Add(925, "&Nu;");
            EscChars.Add(926, "&Xi;");
            EscChars.Add(927, "&Omicron;");
            EscChars.Add(928, "&Pi;");
            EscChars.Add(929, "&Rho;");
            EscChars.Add(931, "&Sigma;");
            EscChars.Add(932, "&Tau;");
            EscChars.Add(933, "&Upsilon;");
            EscChars.Add(934, "&Phi;");
            EscChars.Add(935, "&Chi;");
            EscChars.Add(936, "&Psi;");
            EscChars.Add(937, "&Omega;");
            EscChars.Add(945, "&alpha;");
            EscChars.Add(946, "&beta;");
            EscChars.Add(947, "&gamma;");
            EscChars.Add(948, "&delta;");
            EscChars.Add(949, "&epsilon;");
            EscChars.Add(950, "&zeta;");
            EscChars.Add(951, "&eta;");
            EscChars.Add(952, "&theta;");
            EscChars.Add(953, "&iota;");
            EscChars.Add(954, "&kappa;");
            EscChars.Add(955, "&lambda;");
            EscChars.Add(956, "&mu;");
            EscChars.Add(957, "&nu;");
            EscChars.Add(958, "&xi;");
            EscChars.Add(959, "&omicron;");
            EscChars.Add(960, "&pi;");
            EscChars.Add(961, "&rho;");
            EscChars.Add(962, "&sigmaf;");
            EscChars.Add(963, "&sigma;");
            EscChars.Add(964, "&tau;");
            EscChars.Add(965, "&upsilon;");
            EscChars.Add(966, "&phi;");
            EscChars.Add(967, "&chi;");
            EscChars.Add(968, "&psi;");
            EscChars.Add(969, "&omega;");
            EscChars.Add(977, "&thetasym;");
            EscChars.Add(978, "&upsih;");
            EscChars.Add(982, "&piv;");
            EscChars.Add(8194, "&ensp;");
            EscChars.Add(8195, "&emsp;");
            EscChars.Add(8201, "&thinsp;");
            EscChars.Add(8204, "&zwnj;");
            EscChars.Add(8205, "&zwj;");
            EscChars.Add(8206, "&lrm;");
            EscChars.Add(8207, "&rlm;");
            EscChars.Add(8211, "&ndash;");
            EscChars.Add(8212, "&mdash;");
            EscChars.Add(8216, "&lsquo;");
            EscChars.Add(8217, "&rsquo;");
            EscChars.Add(8218, "&sbquo;");
            EscChars.Add(8220, "&ldquo;");
            EscChars.Add(8221, "&rdquo;");
            EscChars.Add(8222, "&bdquo;");
            EscChars.Add(8224, "&dagger;");
            EscChars.Add(8225, "&Dagger;");
            EscChars.Add(8226, "&bull;");
            EscChars.Add(8230, "&hellip;");
            EscChars.Add(8240, "&permil;");
            EscChars.Add(8242, "&prime;");
            EscChars.Add(8243, "&Prime;");
            EscChars.Add(8249, "&lsaquo;");
            EscChars.Add(8250, "&rsaquo;");
            EscChars.Add(8254, "&oline;");
            EscChars.Add(8260, "&frasl;");
            EscChars.Add(8364, "&euro;");
            EscChars.Add(8465, "&image;");
            EscChars.Add(8472, "&weierp;");
            EscChars.Add(8476, "&real;");
            EscChars.Add(8482, "&trade;");
            EscChars.Add(8501, "&alefsym;");
            EscChars.Add(8592, "&larr;");
            EscChars.Add(8593, "&uarr;");
            EscChars.Add(8594, "&rarr;");
            EscChars.Add(8595, "&darr;");
            EscChars.Add(8596, "&harr;");
            EscChars.Add(8629, "&crarr;");
            EscChars.Add(8656, "&lArr;");
            EscChars.Add(8657, "&uArr;");
            EscChars.Add(8658, "&rArr;");
            EscChars.Add(8659, "&dArr;");
            EscChars.Add(8660, "&hArr;");
            EscChars.Add(8704, "&forall;");
            EscChars.Add(8706, "&part;");
            EscChars.Add(8707, "&exist;");
            EscChars.Add(8709, "&empty;");
            EscChars.Add(8711, "&nabla;");
            EscChars.Add(8712, "&isin;");
            EscChars.Add(8713, "&notin;");
            EscChars.Add(8715, "&ni;");
            EscChars.Add(8719, "&prod;");
            EscChars.Add(8721, "&sum;");
            EscChars.Add(8722, "&minus;");
            EscChars.Add(8727, "&lowast;");
            EscChars.Add(8730, "&radic;");
            EscChars.Add(8733, "&prop;");
            EscChars.Add(8734, "&infin;");
            EscChars.Add(8736, "&ang;");
            EscChars.Add(8743, "&and;");
            EscChars.Add(8744, "&or;");
            EscChars.Add(8745, "&cap;");
            EscChars.Add(8746, "&cup;");
            EscChars.Add(8747, "&int;");
            EscChars.Add(8756, "&there4;");
            EscChars.Add(8764, "&sim;");
            EscChars.Add(8773, "&cong;");
            EscChars.Add(8776, "&asymp;");
            EscChars.Add(8800, "&ne;");
            EscChars.Add(8801, "&equiv;");
            EscChars.Add(8804, "&le;");
            EscChars.Add(8805, "&ge;");
            EscChars.Add(8834, "&sub;");
            EscChars.Add(8835, "&sup;");
            EscChars.Add(8836, "&nsub;");
            EscChars.Add(8838, "&sube;");
            EscChars.Add(8839, "&supe;");
            EscChars.Add(8853, "&oplus;");
            EscChars.Add(8855, "&otimes;");
            EscChars.Add(8869, "&perp;");
            EscChars.Add(8901, "&sdot;");
            EscChars.Add(8942, "&vellip;");
            EscChars.Add(8968, "&lceil;");
            EscChars.Add(8969, "&rceil;");
            EscChars.Add(8970, "&lfloor;");
            EscChars.Add(8971, "&rfloor;");
            EscChars.Add(9001, "&lang;");
            EscChars.Add(9002, "&rang;");
            EscChars.Add(9674, "&loz;");
            EscChars.Add(9824, "&spades;");
            EscChars.Add(9827, "&clubs;");
            EscChars.Add(9829, "&hearts;");
            EscChars.Add(9830, "&diams;");
        }

        private static bool comment = false;
        private static bool cdata = false;

        private string Escape(char[] ch, int Start, int length)
        {
            string text = "";

            int limit = Start + length;

            for (int i = Start; i < limit; i++)
            {
                if (EscHandler.comment)
                {
                    text += ch[i];
                    if (2 < length - i && '-' == ch[i] && '-' == ch[i + 1] && '>' == ch[i + 2])
                    {
                        EscHandler.comment = false;
                        text += "->";
                        i += 2;
                    }
                }
                else if (EscHandler.cdata)
                {
                    text += ch[i];
                    if (2 < length - i && ']' == ch[i] && ']' == ch[i + 1] && '>' == ch[i + 2])
                    {
                        EscHandler.cdata = false;
                        text += "]>";
                        i += 2;
                    }
                }
                else if (3 < length - i && '<' == ch[i] && '!' == ch[i + 1] && '-' == ch[i + 2] && '-' == ch[i + 3])
                {
                    EscHandler.comment = true;
                    text += "<!--";
                    i += 3;
                }
                else if (8 < length - i && '<' == ch[i] && '!' == ch[i + 1] && '[' == ch[i + 2] && 'C' == ch[i + 3])
                {
                    EscHandler.cdata = true;
                    text += "<![CDATA[";
                    i += 8;
                }
                else if ('&' == ch[i])
                {
                    string entity = "&";

                    bool done = false;
                    int pos = i + 1;

                    // TODO: Make 'limit' smaller
                    for (; !done && pos < limit; pos++)
                    {
                        entity += System.Char.ToString(ch[pos]);
                        if (';' == ch[pos])
                            done = true;
                    }

                    if (entity.Equals("&amp;") || EscHandler.EscChars.ContainsValue(entity))
                    {
                        text += entity;
                        i = pos - 1;
                    }
                    else if (entity.Length > 3 && entity[1] == '#')
                    {
                        int entity_value;
                        if (Int32.TryParse(entity.Substring(2, entity.Length - 3), out entity_value) && EscHandler.EscChars.ContainsKey(entity_value))
                            text += EscHandler.EscChars[entity_value];
                        else
                            text += entity;
                        i = pos - 1;
                    }
                    else
                        text += "&amp;";
                }
                else
                {
                    int escChar = (int)ch[i];
                    if (EscHandler.EscChars.ContainsKey(escChar))
                        text += EscHandler.EscChars[escChar];
                    else if (ch[i] > '\u007f')
                        text += "&#" + escChar.ToString() + ";";
                    else
                        text += ch[i];
                }
            }

            return text;
        }

        /// <summary>
        ///   Call used by <see cref="WalkerPlatform.HandleEntities(string, bool)"/>
        ///   to identify and perserve entitities
        /// </summary>
        /// <param name="content">content to be examined</param>
        /// <returns>content with entities perserved</returns>
        public string Escape(string content)
        {
            if (null == content)
                return null;
            return Escape(content.ToCharArray(), 0, content.Length);
        }
    }
}