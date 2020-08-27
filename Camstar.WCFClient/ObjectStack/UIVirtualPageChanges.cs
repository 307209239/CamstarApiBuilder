// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIVirtualPageChanges
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
  public class UIVirtualPageChanges : UIProviderComponentChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_MenuName")]
    protected Primitive<string> _MenuName;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_CodeBehindFile")]
    protected Primitive<string> _CodeBehindFile;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_TemplatePage")]
    protected Primitive<string> _TemplatePage;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_UserPersonalizations")]
    protected UIPersonalizationChanges[] _UserPersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_DeveloperPersonalization")]
    protected UIPersonalizationChanges _DeveloperPersonalization;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_WorkspacePersonalizations")]
    protected UIPersonalizationChanges[] _WorkspacePersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_IncludesReportsOrCharts")]
    protected Primitive<bool> _IncludesReportsOrCharts;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageChanges_EProcEnabled")]
    protected Primitive<bool> _EProcEnabled;

    public override bool Equals(object obj)
    {
      return obj is UIVirtualPageChanges && object.Equals((object) this._MenuName, (object) ((UIVirtualPageChanges) obj)._MenuName) && (object.Equals((object) this._Name, (object) ((UIVirtualPageChanges) obj)._Name) && object.Equals((object) this._CodeBehindFile, (object) ((UIVirtualPageChanges) obj)._CodeBehindFile)) && (object.Equals((object) this._TemplatePage, (object) ((UIVirtualPageChanges) obj)._TemplatePage) && object.Equals((object) this._ObjectToChange, (object) ((UIVirtualPageChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._UserPersonalizations, (Array) ((UIVirtualPageChanges) obj)._UserPersonalizations) && object.Equals((object) this._DeveloperPersonalization, (object) ((UIVirtualPageChanges) obj)._DeveloperPersonalization))) && (this.CompareArrays((Array) this._WorkspacePersonalizations, (Array) ((UIVirtualPageChanges) obj)._WorkspacePersonalizations) && object.Equals((object) this._IncludesReportsOrCharts, (object) ((UIVirtualPageChanges) obj)._IncludesReportsOrCharts) && object.Equals((object) this._EProcEnabled, (object) ((UIVirtualPageChanges) obj)._EProcEnabled)) && base.Equals(obj);
    }

    public Primitive<string> MenuName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MenuName));
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

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public UIPersonalizationChanges[] UserPersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserPersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges[]) this.PropertyGet(nameof (UserPersonalizations));
      }
    }

    public UIPersonalizationChanges DeveloperPersonalization
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeveloperPersonalization), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges) this.PropertyGet(nameof (DeveloperPersonalization));
      }
    }

    public UIPersonalizationChanges[] WorkspacePersonalizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspacePersonalizations), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges[]) this.PropertyGet(nameof (WorkspacePersonalizations));
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
  }
}
