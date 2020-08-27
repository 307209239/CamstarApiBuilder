// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIVirtualPageChanges_Environment
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
  public class UIVirtualPageChanges_Environment : UIProviderComponentChanges_Environment
  {
    [Metadata("Caption", "", false, false, false, "String", 1051510, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Environment_MenuName")]
    protected Environment _MenuName;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Environment_Name")]
    [Metadata("FileName - used for fields that specify files.", "", false, true, false, "String", 1052208, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Environment_CodeBehindFile")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1051509, false, false, false, null)]
    protected Environment _CodeBehindFile;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Environment_TemplatePage")]
    [Metadata("URL", "", false, false, false, "String", 1051511, false, false, false, null)]
    protected Environment _TemplatePage;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Environment_ObjectToChange")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("UI Personalization data", "UIPersonalizationChanges", false, false, false, "UIPersonalizationChanges", 1051514, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Environment_UserPersonalizations")]
    protected UIPersonalizationChanges_Environment _UserPersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Environment_DeveloperPersonalization")]
    [Metadata("UI Personalization data", "UIPersonalizationChanges", false, false, false, "UIPersonalizationChanges", 1052352, false, false, false, null)]
    protected UIPersonalizationChanges_Environment _DeveloperPersonalization;
    [Metadata("UI Personalization data", "UIPersonalizationChanges", false, false, false, "UIPersonalizationChanges", 1053271, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Environment_WorkspacePersonalizations")]
    protected UIPersonalizationChanges_Environment _WorkspacePersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Environment_IncludesReportsOrCharts")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052135, false, false, false, "0")]
    protected Environment _IncludesReportsOrCharts;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053200, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Environment_EProcEnabled")]
    protected Environment _EProcEnabled;

    public Environment MenuName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MenuName));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment CodeBehindFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (CodeBehindFile), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CodeBehindFile));
      }
    }

    public Environment TemplatePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TemplatePage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TemplatePage));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public UIPersonalizationChanges_Environment UserPersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserPersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Environment) this.PropertyGet(nameof (UserPersonalizations));
      }
    }

    public UIPersonalizationChanges_Environment DeveloperPersonalization
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeveloperPersonalization), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Environment) this.PropertyGet(nameof (DeveloperPersonalization));
      }
    }

    public UIPersonalizationChanges_Environment WorkspacePersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspacePersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Environment) this.PropertyGet(nameof (WorkspacePersonalizations));
      }
    }

    public Environment IncludesReportsOrCharts
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludesReportsOrCharts), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludesReportsOrCharts));
      }
    }

    public Environment EProcEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (EProcEnabled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EProcEnabled));
      }
    }
  }
}
