// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorDetails
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
  public class CollaboratorDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_GeneralInstructions")]
    protected Primitive<string> _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_CollaboratorEntries")]
    protected CollaboratorEntryDetails[] _CollaboratorEntries;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_CollaboratorTemplate")]
    protected NamedObjectRef _CollaboratorTemplate;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_EMailMessageToCollaborator")]
    protected NamedObjectRef _EMailMessageToCollaborator;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_CollaboratorData")]
    protected SubentityRef _CollaboratorData;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_EMailMessageToOwner")]
    protected NamedObjectRef _EMailMessageToOwner;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_NotifyCollaborators")]
    protected Primitive<bool> _NotifyCollaborators;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_CurrentSheetLevel")]
    protected Primitive<int> _CurrentSheetLevel;

    public override bool Equals(object obj)
    {
      return obj is CollaboratorDetails && object.Equals((object) this._GeneralInstructions, (object) ((CollaboratorDetails) obj)._GeneralInstructions) && (this.CompareArrays((Array) this._CollaboratorEntries, (Array) ((CollaboratorDetails) obj)._CollaboratorEntries) && object.Equals((object) this._CollaboratorTemplate, (object) ((CollaboratorDetails) obj)._CollaboratorTemplate)) && (object.Equals((object) this._EMailMessageToCollaborator, (object) ((CollaboratorDetails) obj)._EMailMessageToCollaborator) && object.Equals((object) this._CollaboratorData, (object) ((CollaboratorDetails) obj)._CollaboratorData) && (object.Equals((object) this._EMailMessageToOwner, (object) ((CollaboratorDetails) obj)._EMailMessageToOwner) && object.Equals((object) this._NotifyCollaborators, (object) ((CollaboratorDetails) obj)._NotifyCollaborators))) && object.Equals((object) this._CurrentSheetLevel, (object) ((CollaboratorDetails) obj)._CurrentSheetLevel) && base.Equals(obj);
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

    public CollaboratorEntryDetails[] CollaboratorEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorEntries), (object) value);
      }
      get
      {
        return (CollaboratorEntryDetails[]) this.PropertyGet(nameof (CollaboratorEntries));
      }
    }

    public NamedObjectRef CollaboratorTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CollaboratorTemplate));
      }
    }

    public NamedObjectRef EMailMessageToCollaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessageToCollaborator), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EMailMessageToCollaborator));
      }
    }

    public SubentityRef CollaboratorData
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorData), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (CollaboratorData));
      }
    }

    public NamedObjectRef EMailMessageToOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessageToOwner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EMailMessageToOwner));
      }
    }

    public Primitive<bool> NotifyCollaborators
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyCollaborators), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (NotifyCollaborators));
      }
    }

    public Primitive<int> CurrentSheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSheetLevel), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CurrentSheetLevel));
      }
    }
  }
}
