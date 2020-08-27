// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusDiagramChgs
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
  public class ResourceStatusDiagramChgs : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_ToStatusCodes")]
    protected NamedObjectRef _ToStatusCodes;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Status")]
    protected Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_FromStatusCode")]
    protected NamedObjectRef _FromStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ResourceStatusDiagramChgs && object.Equals((object) this._ObjectToChange, (object) ((ResourceStatusDiagramChgs) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((ResourceStatusDiagramChgs) obj)._ListItemToChange) && object.Equals((object) this._ToStatusCodes, (object) ((ResourceStatusDiagramChgs) obj)._ToStatusCodes)) && (object.Equals((object) this._Status, (object) ((ResourceStatusDiagramChgs) obj)._Status) && object.Equals((object) this._FromStatusCode, (object) ((ResourceStatusDiagramChgs) obj)._FromStatusCode) && object.Equals((object) this._IsFrozen, (object) ((ResourceStatusDiagramChgs) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedObjectRef ToStatusCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStatusCodes), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToStatusCodes));
      }
    }

    public Enumeration<StatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<StatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public NamedObjectRef FromStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStatusCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FromStatusCode));
      }
    }

    public Primitive<bool> IsFrozen
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
  }
}
