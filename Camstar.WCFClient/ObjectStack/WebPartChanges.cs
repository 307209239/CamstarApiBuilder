// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WebPartChanges
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
  public class WebPartChanges : UIProviderComponentChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_DeveloperPersonalization")]
    protected UIPersonalizationChanges _DeveloperPersonalization;
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_WorkspacePersonalizations")]
    protected UIPersonalizationChanges[] _WorkspacePersonalizations;
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WebPartChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is WebPartChanges && object.Equals((object) this._DeveloperPersonalization, (object) ((WebPartChanges) obj)._DeveloperPersonalization) && (this.CompareArrays((Array) this._WorkspacePersonalizations, (Array) ((WebPartChanges) obj)._WorkspacePersonalizations) && object.Equals((object) this._ObjectToChange, (object) ((WebPartChanges) obj)._ObjectToChange)) && object.Equals((object) this._Name, (object) ((WebPartChanges) obj)._Name) && base.Equals(obj);
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
  }
}
