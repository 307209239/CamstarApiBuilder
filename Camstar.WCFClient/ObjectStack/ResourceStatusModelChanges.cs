// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusModelChanges
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
  public class ResourceStatusModelChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusModelChanges_InitStatusCodes")]
    protected NamedObjectRef _InitStatusCodes;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusModelChanges_ResourceStatusDiagram")]
    protected ResourceStatusDiagramChgs[] _ResourceStatusDiagram;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusModelChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusModelChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ResourceStatusModelChanges && object.Equals((object) this._InitStatusCodes, (object) ((ResourceStatusModelChanges) obj)._InitStatusCodes) && (this.CompareArrays((Array) this._ResourceStatusDiagram, (Array) ((ResourceStatusModelChanges) obj)._ResourceStatusDiagram) && object.Equals((object) this._ObjectToChange, (object) ((ResourceStatusModelChanges) obj)._ObjectToChange)) && object.Equals((object) this._Name, (object) ((ResourceStatusModelChanges) obj)._Name) && base.Equals(obj);
    }

    public NamedObjectRef InitStatusCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitStatusCodes), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (InitStatusCodes));
      }
    }

    public ResourceStatusDiagramChgs[] ResourceStatusDiagram
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusDiagram), (object) value);
      }
      get
      {
        return (ResourceStatusDiagramChgs[]) this.PropertyGet(nameof (ResourceStatusDiagram));
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
