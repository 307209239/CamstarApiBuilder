// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIVirtualPage_Info
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
  public class UIVirtualPage_Info : UIProviderComponent_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_CodeBehindFile")]
    protected Info _CodeBehindFile;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_SubMenuName")]
    protected Info _SubMenuName;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_TemplatePage")]
    protected Info _TemplatePage;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_DeveloperPersonalization")]
    protected UIPersonalization_Info _DeveloperPersonalization;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_ModelingInstanceLocks")]
    protected new Info _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_UserPersonalizations")]
    protected UIPersonalization_Info _UserPersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_WorkspacePersonalizations")]
    protected UIPersonalization_Info _WorkspacePersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_IncludesReportsOrCharts")]
    protected Info _IncludesReportsOrCharts;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_InstanceLocked")]
    protected new Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_AssociatedPackages")]
    protected new Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_EProcEnabled")]
    protected Info _EProcEnabled;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_CreatedBy")]
    protected new Info _CreatedBy;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_Notes")]
    protected new Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Info_ChangeHistory")]
    protected new ChangeHistory_Info _ChangeHistory;

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

    public Info SubMenuName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubMenuName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubMenuName));
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

    public UIPersonalization_Info DeveloperPersonalization
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeveloperPersonalization), (object) value);
      }
      get
      {
        return (UIPersonalization_Info) this.PropertyGet(nameof (DeveloperPersonalization));
      }
    }

    public new Info FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new Info ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public UIPersonalization_Info UserPersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserPersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalization_Info) this.PropertyGet(nameof (UserPersonalizations));
      }
    }

    public UIPersonalization_Info WorkspacePersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspacePersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalization_Info) this.PropertyGet(nameof (WorkspacePersonalizations));
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

    public new Info InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Info AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssociatedPackages));
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

    public new Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public new Info CreatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreatedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreatedBy));
      }
    }

    public new Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Info IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IconId));
      }
    }

    public new ChangeHistory_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }
  }
}
