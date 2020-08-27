// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorEntryChanges
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
  public class CollaboratorEntryChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_SpecialInstructions")]
    protected Primitive<string> _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Status")]
    protected Enumeration<CollaborateStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_DurationUOM")]
    protected Enumeration<DurationUOMEnum, string> _DurationUOM;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_SubstituteOption")]
    protected Enumeration<ApprovalSubstituteOptionEnum, int> _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_SheetLevel")]
    protected Primitive<int> _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Collaborator")]
    protected NamedObjectRef _Collaborator;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Duration")]
    protected Primitive<double> _Duration;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is CollaboratorEntryChanges && object.Equals((object) this._SpecialInstructions, (object) ((CollaboratorEntryChanges) obj)._SpecialInstructions) && (object.Equals((object) this._Role, (object) ((CollaboratorEntryChanges) obj)._Role) && object.Equals((object) this._Status, (object) ((CollaboratorEntryChanges) obj)._Status)) && (object.Equals((object) this._DurationUOM, (object) ((CollaboratorEntryChanges) obj)._DurationUOM) && object.Equals((object) this._SubstituteOption, (object) ((CollaboratorEntryChanges) obj)._SubstituteOption) && (object.Equals((object) this._SheetLevel, (object) ((CollaboratorEntryChanges) obj)._SheetLevel) && object.Equals((object) this._Collaborator, (object) ((CollaboratorEntryChanges) obj)._Collaborator))) && (object.Equals((object) this._Duration, (object) ((CollaboratorEntryChanges) obj)._Duration) && object.Equals((object) this._IsFrozen, (object) ((CollaboratorEntryChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public Primitive<string> SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public NamedObjectRef Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Role));
      }
    }

    public Enumeration<CollaborateStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<CollaborateStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public Enumeration<DurationUOMEnum, string> DurationUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (DurationUOM), (object) value);
      }
      get
      {
        return (Enumeration<DurationUOMEnum, string>) this.PropertyGet(nameof (DurationUOM));
      }
    }

    public Enumeration<ApprovalSubstituteOptionEnum, int> SubstituteOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstituteOption), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalSubstituteOptionEnum, int>) this.PropertyGet(nameof (SubstituteOption));
      }
    }

    public Primitive<int> SheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SheetLevel), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SheetLevel));
      }
    }

    public NamedObjectRef Collaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Collaborator), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Collaborator));
      }
    }

    public Primitive<double> Duration
    {
      [param: In] set
      {
        this.PropertySet(nameof (Duration), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Duration));
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
