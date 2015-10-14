using UnityEngine;
using System;
using UnityEngine.UI.Windows.Components.Events;

namespace UnityEngine.UI.Windows.Components {

	public class ButtonComponentParameters : WindowComponentParametersBase {

		[Header("Button: Base")]
		[ParamFlag(ParameterFlag.P1)] public bool interactableByDefault = true;
		[ParamFlag(ParameterFlag.P2)] public ComponentEvent callback = new ComponentEvent();

		[Header("Button: SFX")]
		[ParamFlag(ParameterFlag.P7)] public Audio.Component sfxOnClick = new Audio.Component();
		[ParamFlag(ParameterFlag.P8)] public Audio.Component sfxOnEnter = new Audio.Component();
		[ParamFlag(ParameterFlag.P9)] public Audio.Component sfxOnLeave = new Audio.Component();

		[Header("Button: Hover")]
		[ParamFlag(ParameterFlag.P3)] public bool hoverIsActive = true;
		[ParamFlag(ParameterFlag.P4)] public bool hoverOnAnyPointerState = false;
		[ParamFlag(ParameterFlag.P5)] public ComponentEvent hoverInCallback = new ComponentEvent();
		[ParamFlag(ParameterFlag.P6)] public ComponentEvent hoverOutCallback = new ComponentEvent();

		public void Setup(ISelectable component) {
			
			if (this.IsChanged(ParameterFlag.P1) == true) component.SetEnabledState(this.interactableByDefault);
			if (this.IsChanged(ParameterFlag.P2) == true) {

				component.SetCallback(() => this.callback.Invoke());

			}
			
			if (this.IsChanged(ParameterFlag.P3) == true) component.SetHoverState(this.hoverIsActive);
			if (this.IsChanged(ParameterFlag.P4) == true) component.SetHoverOnAnyPointerState(this.hoverOnAnyPointerState);

			if (this.IsChanged(ParameterFlag.P5) == true) {
				
				component.SetCallbackHover((state) => {
					
					if (state == true) {
						
						this.hoverInCallback.Invoke();
						
					}
					
				});

			}

			if (this.IsChanged(ParameterFlag.P6) == true) {

				component.SetCallbackHover((state) => {

					if (state == false) {

						this.hoverOutCallback.Invoke();

					}

				});

			}
			
			if (this.IsChanged(ParameterFlag.P7) == true) component.SetSFX(PointerEventState.Click, this.sfxOnClick);
			if (this.IsChanged(ParameterFlag.P8) == true) component.SetSFX(PointerEventState.Enter, this.sfxOnEnter);
			if (this.IsChanged(ParameterFlag.P9) == true) component.SetSFX(PointerEventState.Leave, this.sfxOnLeave);

		}
		
		#region macros UI.Windows.TextComponentParameters (flagPrefix:A)

	/*
	 * This code is auto-generated by Macros Module
	 * Do not change anything
	 */
	[Header("Text: Base")]
			[Multiline]
			[ParamFlag(ParameterFlag.AP1)] public string text;
			[ParamFlag(ParameterFlag.AP2)] public Color color = Color.white;
			[ParamFlag(ParameterFlag.AP3)] public TextComponent.ValueFormat format = TextComponent.ValueFormat.None;
	
			[Header("Text: Character")]
			[ParamFlag(ParameterFlag.AP4)] public Font font;
			[ParamFlag(ParameterFlag.AP5)] public int fontSize = 16;
			[ParamFlag(ParameterFlag.AP6)] public FontStyle fontStyle = FontStyle.Normal;
			[ParamFlag(ParameterFlag.AP7)] public float lineSpacing = 1f;
			[ParamFlag(ParameterFlag.AP8)] public bool richText = false;
	
			[Header("Text: Paragraph")]
			[ParamFlag(ParameterFlag.AP9)] public TextAnchor alignment = TextAnchor.UpperLeft;
			[ParamFlag(ParameterFlag.AP10)] public VerticalWrapMode verticalWrap = VerticalWrapMode.Truncate;
			[ParamFlag(ParameterFlag.AP11)] public HorizontalWrapMode horizontalWrap = HorizontalWrapMode.Wrap;
			[ParamFlag(ParameterFlag.AP12)] public bool bestFit = false;
			[ParamFlag(ParameterFlag.AP13)] public int bestMinSize = 10;
			[ParamFlag(ParameterFlag.AP14)] public int bestMaxSize = 40;
	
			public void Setup(ITextComponent component) {
				
				if (this.IsChanged(ParameterFlag.AP1) == true) component.SetText(this.text);
				if (this.IsChanged(ParameterFlag.AP2) == true) component.SetTextColor(this.color);
				if (this.IsChanged(ParameterFlag.AP3) == true) component.SetValueFormat(this.format);
	
				if (this.IsChanged(ParameterFlag.AP4) == true) component.SetFont(this.font);
				if (this.IsChanged(ParameterFlag.AP5) == true) component.SetFontSize(this.fontSize);
				if (this.IsChanged(ParameterFlag.AP6) == true) component.SetFontStyle(this.fontStyle);
				if (this.IsChanged(ParameterFlag.AP7) == true) component.SetLineSpacing(this.lineSpacing);
				if (this.IsChanged(ParameterFlag.AP8) == true) component.SetRichText(this.richText);
	
				if (this.IsChanged(ParameterFlag.AP9) == true) component.SetTextAlignment(this.alignment);
				if (this.IsChanged(ParameterFlag.AP10) == true) component.SetTextVerticalOverflow(this.verticalWrap);
				if (this.IsChanged(ParameterFlag.AP11) == true) component.SetTextHorizontalOverflow(this.horizontalWrap);
				if (this.IsChanged(ParameterFlag.AP12) == true) component.SetBestFitState(this.bestFit);
				if (this.IsChanged(ParameterFlag.AP13) == true) component.SetBestFitMinSize(this.bestMinSize);
				if (this.IsChanged(ParameterFlag.AP14) == true) component.SetBestFitMaxSize(this.bestMaxSize);
	
			}
	#endregion
		
		#region macros UI.Windows.ImageComponentParameters (flagPrefix:B)

	/*
	 * This code is auto-generated by Macros Module
	 * Do not change anything
	 */
	[Header("Image: Base")]
			[ParamFlag(ParameterFlag.BP1)] public bool preserveAspect;
			[ParamFlag(ParameterFlag.BP2)] public Sprite image;
			[ParamFlag(ParameterFlag.BP3)] public Texture rawImage;
			[ParamFlag(ParameterFlag.BP4)] public Color imageColor = Color.white;
	
			public void Setup(IImageComponent component) {
				
				if (this.IsChanged(ParameterFlag.BP1) == true) component.SetPreserveAspectState(this.preserveAspect);
				if (this.IsChanged(ParameterFlag.BP2) == true) component.SetImage(this.image);
				if (this.IsChanged(ParameterFlag.BP3) == true) component.SetImage(this.rawImage);
				if (this.IsChanged(ParameterFlag.BP4) == true) component.SetColor(this.imageColor);
	
			}
	#endregion

	}

}