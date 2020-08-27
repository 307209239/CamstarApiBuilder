// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.InstructionItemChanges
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
  public class InstructionItemChanges : TaskItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "InstructionItemChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "InstructionItemChanges_InstructionType")]
    protected new Enumeration<InstructionTypeEnum, int> _InstructionType;
    [DataMember(EmitDefaultValue = false, Name = "InstructionItemChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "InstructionItemChanges_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;

    public override bool Equals(object obj)
    {
      return obj is InstructionItemChanges && object.Equals((object) this._ObjectToChange, (object) ((InstructionItemChanges) obj)._ObjectToChange) && (object.Equals((object) this._InstructionType, (object) ((InstructionItemChanges) obj)._InstructionType) && object.Equals((object) this._ListItemToChange, (object) ((InstructionItemChanges) obj)._ListItemToChange)) && object.Equals((object) this._DataCollectionDef, (object) ((InstructionItemChanges) obj)._DataCollectionDef) && base.Equals(obj);
    }

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Enumeration<InstructionTypeEnum, int> InstructionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstructionType), (object) value);
      }
      get
      {
        return (Enumeration<InstructionTypeEnum, int>) this.PropertyGet(nameof (InstructionType));
      }
    }

    public new NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
    }
  }
}
