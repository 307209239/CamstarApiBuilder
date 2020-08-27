// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorEntryChanges_Info
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
  public class CollaboratorEntryChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Info_SpecialInstructions")]
    protected Info _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Info_DurationUOM")]
    protected Info _DurationUOM;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Info_SubstituteOption")]
    protected Info _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Info_SheetLevel")]
    protected Info _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Info_Collaborator")]
    protected Info _Collaborator;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Info_Duration")]
    protected Info _Duration;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public Info DurationUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (DurationUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DurationUOM));
      }
    }

    public Info SubstituteOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstituteOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubstituteOption));
      }
    }

    public Info SheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SheetLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SheetLevel));
      }
    }

    public Info Collaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Collaborator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Collaborator));
      }
    }

    public Info Duration
    {
      [param: In] set
      {
        this.PropertySet(nameof (Duration), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Duration));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
