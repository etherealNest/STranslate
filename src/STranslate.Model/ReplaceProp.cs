using CommunityToolkit.Mvvm.ComponentModel;

namespace STranslate.Model;

public partial class ReplaceProp : ObservableObject
{
    [ObservableProperty] private ITranslator? _activeService;

    [ObservableProperty] private double _autoScale = 0.8;

    [ObservableProperty] private LangDetectType _detectType;

    [ObservableProperty] private LangEnum _sourceLang;

    [ObservableProperty] private LangEnum _targetLang;
    /// <summary>
    ///     原始语言识别为自动时使用该配置
    ///     * 使用在线识别服务出错时使用
    /// </summary>
    [ObservableProperty] private LangEnum _sourceLangIfAuto = LangEnum.en;

    /// <summary>
    ///     目标语种为自动时
    ///     * 原始语种识别为首选语言
    ///     * 目标语种使用该配置
    /// </summary>
    [ObservableProperty] private LangEnum _targetLangIfPrimary = LangEnum.en;

    /// <summary>
    ///     目标语种为自动时
    ///     * 原始语种识别为非首选语言
    ///     * 目标语种使用该配置
    /// </summary>
    [ObservableProperty] private LangEnum _targetLangIfNotPrimary = LangEnum.zh_cn;

    /// <summary>
    ///     首选语言
    /// </summary>
    [ObservableProperty] private LangEnum _primaryLanguage = LangEnum.zh_cn;

    public ReplaceProp Clone()
    {
        return new ReplaceProp
        {
            ActiveService = ActiveService?.Clone(),
            AutoScale = AutoScale,
            DetectType = DetectType,
            SourceLang = SourceLang,
            TargetLang = TargetLang,
            SourceLangIfAuto = SourceLangIfAuto,
            TargetLangIfPrimary = TargetLangIfPrimary,
            TargetLangIfNotPrimary = TargetLangIfNotPrimary,
            PrimaryLanguage = PrimaryLanguage,
        };
    }

    /// <summary>
    ///     从另一个 ReplaceProp 实例复制所有属性到当前实例
    /// </summary>
    /// <param name="source">源 ReplaceProp 实例</param>
    public void CopyFrom(ReplaceProp source)
    {
        if (source == null)
            return;

        ActiveService = source.ActiveService?.Clone();
        AutoScale = source.AutoScale;
        DetectType = source.DetectType;
        SourceLang = source.SourceLang;
        TargetLang = source.TargetLang;
        SourceLangIfAuto = source.SourceLangIfAuto;
        TargetLangIfPrimary = source.TargetLangIfPrimary;
        TargetLangIfNotPrimary = source.TargetLangIfNotPrimary;
        PrimaryLanguage = source.PrimaryLanguage;
    }
}