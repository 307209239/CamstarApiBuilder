// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalTabChanges
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
  public class PortalTabChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalTabChanges_IconUrl")]
    protected Primitive<string> _IconUrl;
    [DataMember(EmitDefaultValue = false, Name = "PortalTabChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalTabChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is PortalTabChanges && object.Equals((object) this._IconUrl, (object) ((PortalTabChanges) obj)._IconUrl) && (object.Equals((object) this._ObjectToChange, (object) ((PortalTabChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((PortalTabChanges) obj)._Name)) && base.Equals(obj);
    }

    public Primitive<string> IconUrl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconUrl), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IconUrl));
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
