// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIVirtualPageChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UIVirtualPageChanges_Info : UIProviderComponentChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Info_MenuName")]
    protected Info _MenuName;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Info_CodeBehindFile")]
    protected Info _CodeBehindFile;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Info_TemplatePage")]
    protected Info _TemplatePage;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Info_UserPersonalizations")]
    protected UIPersonalizationChanges_Info _UserPersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Info_DeveloperPersonalization")]
    protected UIPersonalizationChanges_Info _DeveloperPersonalization;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Info_WorkspacePersonalizations")]
    protected UIPersonalizationChanges_Info _WorkspacePersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Info_IncludesReportsOrCharts")]
    protected Info _IncludesReportsOrCharts;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Info_EProcEnabled")]
    protected Info _EProcEnabled;

    public Info MenuName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MenuName));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info CodeBehindFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (CodeBehindFile), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CodeBehindFile));
      }
    }

    public Info TemplatePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TemplatePage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TemplatePage));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public UIPersonalizationChanges_Info UserPersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserPersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Info) this.PropertyGet(nameof (UserPersonalizations));
      }
    }

    public UIPersonalizationChanges_Info DeveloperPersonalization
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeveloperPersonalization), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Info) this.PropertyGet(nameof (DeveloperPersonalization));
      }
    }

    public UIPersonalizationChanges_Info WorkspacePersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspacePersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Info) this.PropertyGet(nameof (WorkspacePersonalizations));
      }
    }

    public Info IncludesReportsOrCharts
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludesReportsOrCharts), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludesReportsOrCharts));
      }
    }

    public Info EProcEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (EProcEnabled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EProcEnabled));
      }
    }
  }
}
