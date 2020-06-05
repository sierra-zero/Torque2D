function BaseTheme::onAdd(%this)
{
	%this.init();

	%this.makeTipProfile();
	%this.makePanelProfile();
	%this.makeButtonProfile();
	%this.makeTabProfile();
	%this.makeTextEditProfile();
	%this.makeScrollProfile();
	%this.makeConsoleProfile();
}

function BaseTheme::init(%this)
{
	//fonts and font sizes
	%this.font = "monaco";
	%this.fontSize = 12;
	if ($platform $= "windows")
	{
		%this.font = "lucida console";
	}
	else if ($platform $= "Android")
	{
		%this.font = "Droid";
		%this.fontSize = 14;
	}
	else if($platform $= "ios")
	{
		%this.fontSize = 18;
	}

	%this.color1 = "10 10 10 255";
	%this.color2 = "70 70 70 255";
	%this.color3 = "120 120 120 255";
	%this.color4 = "255 255 255 255";
	%this.color5 = "255 133 0 255";

	%this.borderSize = 3;
}

function BaseTheme::makeTipProfile(%this)
{
	%tipBorder = new GuiBorderProfile()
	{
		padding = 4;
		border = 1;
		borderColor = %this.color1;
	};

	%this.tipProfile = new GuiControlProfile()
	{
		fillColor = %this.setAlpha(%this.color2, 200);

		fontType = %this.font;
		fontSize = %this.fontSize;
		fontColor = %this.color1;

		borderDefault = %tipBorder;
	};
}

function BaseTheme::makePanelProfile(%this)
{
	%panelBorder = new GuiBorderProfile()
	{
		padding = 0;
		border = %this.borderSize;
		borderColor = "0 0 0 60";
	};

	%this.panelProfile = new GuiControlProfile()
	{
		fillColor = %this.color1;

		fontType = %this.font;
		fontSize = %this.fontSize + 2;
		fontColor = %this.color4;
		align = center;
		vAlign = middle;

		borderDefault = %panelBorder;
	};

	%this.fullPanelProfile = new GuiControlProfile()
	{
		fillColor = %this.color1;

		fontType = %this.font;
		fontSize = %this.fontSize;
		fontColor = %this.color4;
		align = center;
		vAlign = middle;
	};

	%this.overlayProfile = new GuiControlProfile()
	{
		fillColor = %this.setAlpha(%this.color1, 150);

		fontType = %this.font;
		fontSize = %this.fontSize;
		fontColor = %this.color4;
	};

	//Scrolling panel
	%this.scrollingPanelTrackProfile = new GuiControlProfile()
	{
		fillColor = %this.color2;
		fillColorHL = %this.color2;
		fillColorSL = %this.color2;
		fillColorNA = %this.setAlpha(%this.color2, 50);
	};

	%thumbBorder = new GuiBorderProfile()
	{
		margin = 3;
		marginHL = 3;
		marginSL = 3;
		paddingNA = 3;
	};

	%this.scrollingPanelThumbProfile = new GuiControlProfile()
	{
		fillColor = %this.color3;
		fillColorHL = %this.adjustValue(%this.color3, 10);
		fillColorSL = %this.color5;
		fillColorNA = %this.setAlpha(%this.color3, 0);

		borderRight = %thumbBorder;
		borderLeft = %thumbBorder;
	};

	%buttonBorder = new GuiBorderProfile()
	{
		padding = 3;
		paddingHL = 3;
		paddingSL = 3;
		paddingNA = 3;
	};

	%this.scrollingPanelArrowProfile = new GuiControlProfile()
	{
		fillColor = %this.color2;
		fillColorHL = %this.color2;
		fillColorSL = %this.color2;
		fillColorNA = %this.setAlpha(%this.color2, 50);

		fontType = %this.font;
		fontColor = %this.color3;
		fontColorHL = %this.adjustValue(%this.color3, 10);
		fontColorSL = %this.color5;
		fontColorNA = %this.setAlpha(%this.color3, 80);

		borderDefault = %buttonBorder;
	};

	%mainBorder = new GuiBorderProfile()
	{
		margin = 5;
		padding = 5;
		border = 3;
		borderColor = %this.color5;
	};
	%this.scrollingPanelProfile = new GuiControlProfile()
	{
	    fillColor = %this.color1;
	};
}

function BaseTheme::makeButtonProfile(%this)
{
	%buttonBorderV = new GuiBorderProfile()
	{
		padding = 6;
		paddingHL = 6 - %this.borderSize;
		paddingSL = 6 - %this.borderSize;
		paddingNA = 6;

		border = 0;
		borderHL = %this.borderSize;
		borderSL = %this.borderSize;
		borderNA = 0;

		borderColor = "0 0 0 0";
		borderColorHL = %this.setAlpha(%this.adjustValue(%this.color2, 10), 170);
		borderColorSL = %this.setAlpha(%this.adjustValue(%this.color5, 10), 170);
		borderColorNA = "0 0 0 0";

		underfill = false;
	};

	%buttonBorderH = new GuiBorderProfile()
	{
		padding = 20;
		paddingHL = 20 - %this.borderSize;
		paddingSL = 20 - %this.borderSize;
		paddingNA = 20;

		border = 0;
		borderHL = %this.borderSize;
		borderSL = %this.borderSize;
		borderNA = 0;

		borderColor = "0 0 0 0";
		borderColorHL = %this.setAlpha(%this.adjustValue(%this.color2, 10), 170);
		borderColorSL = %this.setAlpha(%this.adjustValue(%this.color5, 10), 170);
		borderColorNA = "0 0 0 0";

		underfill = false;
	};

	%this.buttonProfile = new GuiControlProfile()
	{
		fillColor = %this.color2;
		fillColorHL = %this.adjustValue(%this.color2, 10);
		fillColorSL = %this.color3;
		fillColorNA = %this.setAlpha(%this.color2, 80);

		fontType = %this.font;
		fontSize = %this.fontSize + 2;
		fontColor = %this.color4;
		fontColorHL = %this.adjustValue(%this.color4, 10);
		fontColorSL = "0 0 0 255";
		fontColorNA = %this.setAlpha(%this.color4, 100);
		align = Center;

		borderDefault = %buttonBorderV;
		borderRight = %buttonBorderH;
		borderLeft = %buttonBorderH;
	};
}

function BaseTheme::makeTabProfile(%this)
{
	%tabBorderTop = new GuiBorderProfile()
	{
		margin = 2;
		marginHL = 1;
		marginSL = 0;
		marginNA = 2;

		border = 2;
		borderHL = 2;
		borderSL = 2;
		borderNA = 2;

		padding = 1;
		paddingHL = 2;
		paddingSL = 3;
		paddingNA = 0;

		borderColor = "255 255 255 90";
		borderColorHL = "255 255 255 90";
		borderColorSL = "255 255 255 90";
		borderColorNA = "255 255 255 90";
	};

	%tabBorderTopAlt = new GuiBorderProfile()
	{
		margin = 2;
		marginHL = 1;
		marginSL = 0;
		marginNA = 2;

		border = 2;
		borderHL = 2;
		borderSL = 2;
		borderNA = 2;

		padding = 1;
		paddingHL = 2;
		paddingSL = 3;
		paddingNA = 0;

		borderColor = "0 0 0 90";
		borderColorHL = "0 0 0 90";
		borderColorSL = "0 0 0 90";
		borderColorNA = "0 0 0 90";
	};

	%tabBorderLeft = new GuiBorderProfile()
	{
		margin = 2;
		marginHL = 1;
		marginSL = 0;
		marginNA = 2;

		border = 2;
		borderHL = 2;
		borderSL = 2;
		borderNA = 2;

		padding = 10;
		paddingHL = 11;
		paddingSL = 12;
		paddingNA = 10;

		borderColor = "255 255 255 90";
		borderColorHL = "255 255 255 90";
		borderColorSL = "255 255 255 90";
		borderColorNA = "255 255 255 90";
	};

	%tabBorderRight = new GuiBorderProfile()
	{
		margin = 2;
		marginHL = 1;
		marginSL = 0;
		marginNA = 2;

		border = 2;
		borderHL = 2;
		borderSL = 2;
		borderNA = 2;

		padding = 10;
		paddingHL = 11;
		paddingSL = 12;
		paddingNA = 10;

		borderColor = "0 0 0 90";
		borderColorHL = "0 0 0 90";
		borderColorSL = "0 0 0 90";
		borderColorNA = "0 0 0 90";
	};

	%tabBorderBottom = new GuiBorderProfile()
	{
		padding = 2;
		paddingHL = 2;
		paddingSL = 2;
		paddingNA = 2;
	};

	%this.tabProfileTop = new GuiControlProfile ()
	{
		fillColor = %this.color3;
		fillColorHL = %this.adjustValue(%this.color3, 10);
		fillColorSL = %this.color5;
		fillColorNA = %this.setAlpha(%this.color3, 150);

		fontType = %this.font;
		fontSize = %this.fontSize + 2;
		fontColor = %this.color4;
		fontColorHL = %this.adjustValue(%this.color4, 10);
		fontColorSL = %this.color1;
		fontColorNA = %this.setAlpha(%this.color4, 100);
		align = Center;

		borderTop = %tabBorderTop;
		borderLeft = %tabBorderLeft;
		borderRight = %tabBorderRight;
		borderBottom = %tabBorderBottom;
	};

	%this.tabProfileBottom = new GuiControlProfile ()
	{
		fillColor = %this.color3;
		fillColorHL = %this.adjustValue(%this.color3, 10);
		fillColorSL = %this.color5;
		fillColorNA = %this.setAlpha(%this.color3, 150);

		fontType = %this.font;
		fontSize = %this.fontSize + 2;
		fontColor = %this.color4;
		fontColorHL = %this.adjustValue(%this.color4, 10);
		fontColorSL = %this.color1;
		fontColorNA = %this.setAlpha(%this.color4, 100);
		align = Center;

		borderTop = %tabBorderBottom;
		borderLeft = %tabBorderLeft;
		borderRight = %tabBorderRight;
		borderBottom = %tabBorderTopAlt;
	};

	%this.tabProfileLeft = new GuiControlProfile ()
	{
		fillColor = %this.color3;
		fillColorHL = %this.adjustValue(%this.color3, 10);
		fillColorSL = %this.color5;
		fillColorNA = %this.setAlpha(%this.color3, 150);

		fontType = %this.font;
		fontSize = %this.fontSize + 2;
		fontColor = %this.color4;
		fontColorHL = %this.adjustValue(%this.color4, 10);
		fontColorSL = %this.color1;
		fontColorNA = %this.setAlpha(%this.color4, 100);
		align = Center;

		borderTop = %tabBorderLeft;
		borderLeft = %tabBorderTop;
		borderRight = %tabBorderBottom;
		borderBottom = %tabBorderRight;
	};

	%this.tabProfileRight = new GuiControlProfile ()
	{
		fillColor = %this.color3;
		fillColorHL = %this.adjustValue(%this.color3, 10);
		fillColorSL = %this.color5;
		fillColorNA = %this.setAlpha(%this.color3, 150);

		fontType = %this.font;
		fontSize = %this.fontSize + 2;
		fontColor = %this.color4;
		fontColorHL = %this.adjustValue(%this.color4, 10);
		fontColorSL = %this.color1;
		fontColorNA = %this.setAlpha(%this.color4, 100);
		align = Center;

		borderTop = %tabBorderLeft;
		borderLeft = %tabBorderBottom;
		borderRight = %tabBorderTopAlt;
		borderBottom = %tabBorderRight;
	};

	%bookBorderBottom = new GuiBorderProfile()
	{
		margin = 0;
		border = %this.borderSize;
		borderColor = "0 0 0 150";
		padding = 0;
	};

	%bookBorderDefault = new GuiBorderProfile()
	{
		padding = 10;
	};

	%this.tabBookProfileTop = new GuiControlProfile ()
	{
		borderDefault = %bookBorderDefault;
		borderBottom = %bookBorderBottom;
		fillcolor = %this.color2;
	};

	%this.tabBookProfileBottom = new GuiControlProfile ()
	{
		borderDefault = %bookBorderDefault;
		borderTop = %bookBorderBottom;
		fillcolor = %this.color2;
	};

	%this.tabBookProfileLeft = new GuiControlProfile ()
	{
		borderDefault = %bookBorderDefault;
		borderRight = %bookBorderBottom;
		fillcolor = %this.color2;
	};

	%this.tabBookProfileRight = new GuiControlProfile ()
	{
		borderDefault = %bookBorderDefault;
		borderLeft = %bookBorderBottom;
		fillcolor = %this.color2;
	};

	%this.tabPageProfile = new GuiControlProfile ()
	{
	    fillColor = %this.setAlpha(%this.color1, 150);
	};
}

function BaseTheme::makeTextEditProfile(%this)
{
	//border for text boxes never use the HL state.
	%textBorderV = new GuiBorderProfile()
	{
		padding = 2;
		paddingSL = 2;
		paddingNA = 2;

		border = %this.borderSize;
		borderSL = %this.borderSize;
		borderNA = %this.borderSize;

		borderColor = %this.color3;
		borderColorSL = %this.color5;
		borderColorNA = %this.setAlpha(%this.color3, 100);
	};

	%textBorderH = new GuiBorderProfile()
	{
		padding = 10;
		paddingSL = 10;
		paddingNA = 10;

		border = %this.borderSize;
		borderSL = %this.borderSize;
		borderNA = %this.borderSize;

		borderColor = %this.color3;
		borderColorSL = %this.color5;
		borderColorNA = %this.setAlpha(%this.color3, 100);
	};

	%this.textEditProfile = new GuiControlProfile()
	{
		fillColor = %this.color4;
		fillColorHL = %this.color5;//used for selected text
		fillColorSL = %this.color4;
		fillColorNA = %this.setAlpha(%this.color4, 80);

		fontType = %this.font;
		fontSize = %this.fontSize + 2;
		fontColor = %this.setAlpha(%this.color1, 220);
		fontColorHL = %this.adjustValue(%this.color1, 10);
		fontColorSL = %this.color1;
		fontColorNA = %this.setAlpha(%this.color1, 100);
		align = left;
		cursorColor = %this.color1;

		borderDefault = %textBorderV;
		borderRight = %textBorderH;
		borderLeft = %textBorderH;

		tab = false;
		canKeyFocus = true;
		returnTab = true;
	};
}

function BaseTheme::makeScrollProfile(%this)
{
	%trackBorder = new GuiBorderProfile()
	{
		margin = 0;
		padding = 0;
		border = 0;
	};

	%this.trackProfile = new GuiControlProfile()
	{
			fillColor = %this.setAlpha(%this.color2, 150);
			fillColorHL = %this.setAlpha(%this.color2, 150);
			fillColorSL = %this.setAlpha(%this.adjustValue(%this.color2, 10), 150);
			fillColorNA = %this.setAlpha(%this.color2, 50);
			borderDefault = %trackBorder;
	};

	%buttonBorderLT = new GuiBorderProfile()
	{
		padding = 3;
		paddingHL = 2;
		paddingSL = 2;
		paddingNA = 3;

		border = 1;
		borderHL = 2;
		borderSL = 2;
		borderNA = 1;

		borderColor = %this.adjustValue(%this.color3, 20);
		borderColorHL = %this.adjustValue(%this.color3, 30);
		borderColorSL = %this.adjustValue(%this.color5, 20);
		borderColorNA = %this.setAlpha(%this.adjustValue(%this.color3, 20), 80);

		underfill = true;
	};

	%buttonBorderRB = new GuiBorderProfile()
	{
		padding = 3;
		paddingHL = 2;
		paddingSL = 2;
		paddingNA = 3;

		border = 1;
		borderHL = 2;
		borderSL = 2;
		borderNA = 1;

		borderColor = %this.adjustValue(%this.color3, -20);
		borderColorHL = %this.adjustValue(%this.color3, -10);
		borderColorSL = %this.adjustValue(%this.color5, -20);
		borderColorNA = %this.setAlpha(%this.adjustValue(%this.color3, -20), 80);

		underfill = true;
	};

	%this.thumbProfile = new GuiControlProfile()
	{
		fillColor = %this.color3;
		fillColorHL = %this.adjustValue(%this.color3, 10);
		fillColorSL = %this.color5;
		fillColorNA = %this.setAlpha(%this.color3, 80);

		borderDefault = %buttonBorderLT;
		borderRight = %buttonBorderRB;
		borderBottom = %buttonBorderRB;
	};

	%this.scrollArrowProfile = new GuiControlProfile()
	{
		fillColor = %this.color3;
		fillColorHL = %this.adjustValue(%this.color3, 10);
		fillColorSL = %this.color5;
		fillColorNA = %this.setAlpha(%this.color3, 80);

		fontType = %this.font;
		fontColor = %this.color2;
		fontColorHL = %this.color2;
		fontColorSL = %this.color4;
		fontColorNA = %this.setAlpha(%this.color2, 80);

		borderDefault = %buttonBorderLT;
		borderRight = %buttonBorderRB;
		borderBottom = %buttonBorderRB;
	};

	%mainBorder = new GuiBorderProfile()
	{
		margin = 5;
		padding = 5;
		border = 3;
		borderColor = %this.color5;
	};
	%this.scrollProfile = new GuiControlProfile()
	{
			opaque = true;
	    fillColor = %this.setAlpha(%this.color2, 180);

			borderDefault = %mainBorder;
	};
}

function BaseTheme::makeConsoleProfile(%this)
{
	%this.consoleProfile = new GuiControlProfile()
	{
		fontType = %this.font;
		fontColor = %this.color4; //Normal text
		fontColorHL = %this.setAlpha(%this.color4, 140); //Warnings
		fontColorNA = "255 0 0 255"; //Errors
	};
}

function BaseTheme::adjustValue(%this, %color, %percent)
{
	%red = getWord(%color, 0);
	%green = getWord(%color, 1);
	%blue = getWord(%color, 2);
	%alpha = getWord(%color, 3);

	%largest = %red;
	if(%green > %largest)
	{
		%largest = %green;
	}
	if(%blue > %largest)
	{
		%largest = %blue;
	}
	%currentValue = %largest / 255;
	%fullRed = %red / %currentValue;
	%fullGreen = %green / %currentValue;
	%fullBlue = %blue / %currentValue;

	%newValue = %currentValue += (%percent/100);
	%newValue = mClamp(%newValue, 0, 100);
	%newColor = mRound(mClamp((%fullRed * %newValue), 0, 255)) SPC
		mRound(mClamp((%fullGreen * %newValue), 0, 255)) SPC
		mRound(mClamp((%fullBlue * %newValue), 0, 255)) SPC %alpha;

	return %newColor;
}

function BaseTheme::setAlpha(%this, %color, %newAlpha)
{
	%red = getWord(%color, 0);
	%green = getWord(%color, 1);
	%blue = getWord(%color, 2);
	return %red SPC %green SPC %blue SPC mRound(mClamp(%newAlpha, 0, 255));
}