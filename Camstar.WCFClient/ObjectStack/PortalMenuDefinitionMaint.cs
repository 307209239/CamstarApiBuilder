// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuDefinitionMaint
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
  public class PortalMenuDefinitionMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionMaint_ObjectChanges")]
    protected PortalMenuDefinitionChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionMaint_TargetMenu")]
    protected NamedObjectRef _TargetMenu;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;

    public override bool Equals(object obj)
    {
      return obj is PortalMenuDefinitionMaint && object.Equals((object) this._ObjectChanges, (object) ((PortalMenuDefinitionMaint) obj)._ObjectChanges) && (object.Equals((object) this._ObjectToChange, (object) ((PortalMenuDefinitionMaint) obj)._ObjectToChange) && object.Equals((object) this._TargetMenu, (object) ((PortalMenuDefinitionMaint) obj)._TargetMenu)) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((PortalMenuDefinitionMaint) obj)._ObjectListInquiry) && base.Equals(obj);
    }

    public PortalMenuDefinitionChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PortalMenuDefinitionChanges) this.PropertyGet(nameof (ObjectChanges));
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

    public NamedObjectRef TargetMenu
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetMenu), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TargetMenu));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
