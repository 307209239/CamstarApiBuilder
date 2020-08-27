// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIVirtualPage
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
  public class UIVirtualPage : UIProviderComponent
  {
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_CodeBehindFile")]
    protected Primitive<string> _CodeBehindFile;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_SubMenuName")]
    protected Primitive<string> _SubMenuName;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_TemplatePage")]
    protected Primitive<string> _TemplatePage;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_DeveloperPersonalization")]
    protected UIPersonalization _DeveloperPersonalization;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_UserPersonalizations")]
    protected UIPersonalization[] _UserPersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_WorkspacePersonalizations")]
    protected UIPersonalization[] _WorkspacePersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_IncludesReportsOrCharts")]
    protected Primitive<bool> _IncludesReportsOrCharts;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_EProcEnabled")]
    protected Primitive<bool> _EProcEnabled;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_CreatedBy")]
    protected new NamedObjectRef _CreatedBy;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPage_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;

    public override bool Equals(object obj)
    {
      return obj is UIVirtualPage && object.Equals((object) this._CodeBehindFile, (object) ((UIVirtualPage) obj)._CodeBehindFile) && (object.Equals((object) this._Name, (object) ((UIVirtualPage) obj)._Name) && object.Equals((object) this._SubMenuName, (object) ((UIVirtualPage) obj)._SubMenuName)) && (object.Equals((object) this._TemplatePage, (object) ((UIVirtualPage) obj)._TemplatePage) && object.Equals((object) this._DeveloperPersonalization, (object) ((UIVirtualPage) obj)._DeveloperPersonalization) && (object.Equals((object) this._FilterTags, (object) ((UIVirtualPage) obj)._FilterTags) && this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((UIVirtualPage) obj)._ModelingInstanceLocks))) && (this.CompareArrays((Array) this._UserPersonalizations, (Array) ((UIVirtualPage) obj)._UserPersonalizations) && this.CompareArrays((Array) this._WorkspacePersonalizations, (Array) ((UIVirtualPage) obj)._WorkspacePersonalizations) && (object.Equals((object) this._IncludesReportsOrCharts, (object) ((UIVirtualPage) obj)._IncludesReportsOrCharts) && object.Equals((object) this._InstanceLocked, (object) ((UIVirtualPage) obj)._InstanceLocked)) && (object.Equals((object) this._AssociatedPackages, (object) ((UIVirtualPage) obj)._AssociatedPackages) && object.Equals((object) this._EProcEnabled, (object) ((UIVirtualPage) obj)._EProcEnabled) && (object.Equals((object) this._Description, (object) ((UIVirtualPage) obj)._Description) && object.Equals((object) this._CreatedBy, (object) ((UIVirtualPage) obj)._CreatedBy)))) && (object.Equals((object) this._Notes, (object) ((UIVirtualPage) obj)._Notes) && object.Equals((object) this._IsFrozen, (object) ((UIVirtualPage) obj)._IsFrozen) && (object.Equals((object) this._IconId, (object) ((UIVirtualPage) obj)._IconId) && object.Equals((object) this._ChangeHistory, (object) ((UIVirtualPage) obj)._ChangeHistory))) && base.Equals(obj);
    }

    public Primitive<string> CodeBehindFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (CodeBehindFile), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CodeBehindFile));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<string> SubMenuName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubMenuName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SubMenuName));
      }
    }

    public Primitive<string> TemplatePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TemplatePage), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TemplatePage));
      }
    }

    public UIPersonalization DeveloperPersonalization
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeveloperPersonalization), (object) value);
      }
      get
      {
        return (UIPersonalization) this.PropertyGet(nameof (DeveloperPersonalization));
      }
    }

    public new Primitive<string> FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new SubentityRef[] ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public UIPersonalization[] UserPersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserPersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalization[]) this.PropertyGet(nameof (UserPersonalizations));
      }
    }

    public UIPersonalization[] WorkspacePersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspacePersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalization[]) this.PropertyGet(nameof (WorkspacePersonalizations));
      }
    }

    public Primitive<bool> IncludesReportsOrCharts
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludesReportsOrCharts), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludesReportsOrCharts));
      }
    }

    public new Primitive<bool> InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Primitive<int> AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public Primitive<bool> EProcEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (EProcEnabled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (EProcEnabled));
      }
    }

    public new Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public new NamedObjectRef CreatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreatedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CreatedBy));
      }
    }

    public new Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Primitive<int> IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IconId));
      }
    }

    public new ChangeHistory ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory) this.PropertyGet(nameof (ChangeHistory));
      }
    }
  }
}
