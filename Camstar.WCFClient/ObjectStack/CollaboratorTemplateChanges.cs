// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorTemplateChanges
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
  public class CollaboratorTemplateChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateChanges_GeneralInstructions")]
    protected Primitive<string> _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateChanges_CollaboratorEntries")]
    protected CollaboratorEntryChanges[] _CollaboratorEntries;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is CollaboratorTemplateChanges && object.Equals((object) this._GeneralInstructions, (object) ((CollaboratorTemplateChanges) obj)._GeneralInstructions) && (object.Equals((object) this._ObjectToChange, (object) ((CollaboratorTemplateChanges) obj)._ObjectToChange) && this.CompareArrays((Array) this._CollaboratorEntries, (Array) ((CollaboratorTemplateChanges) obj)._CollaboratorEntries)) && object.Equals((object) this._Name, (object) ((CollaboratorTemplateChanges) obj)._Name) && base.Equals(obj);
    }

    public Primitive<string> GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GeneralInstructions));
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

    public CollaboratorEntryChanges[] CollaboratorEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorEntries), (object) value);
      }
      get
      {
        return (CollaboratorEntryChanges[]) this.PropertyGet(nameof (CollaboratorEntries));
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
