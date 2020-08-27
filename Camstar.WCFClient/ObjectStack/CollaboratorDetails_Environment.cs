// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorDetails_Environment
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
  public class CollaboratorDetails_Environment : ServiceDetails_Environment
  {
    [Metadata("Instruction", "", false, false, false, "String", 16778094, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Environment_GeneralInstructions")]
    protected Environment _GeneralInstructions;
    [Metadata("An entry in an collaborator sheet specifies the service details for a single collaborator.", "CollaboratorEntryDetails", false, false, false, "CollaboratorEntryDetails", 16778078, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Environment_CollaboratorEntries")]
    protected CollaboratorEntryDetails_Environment _CollaboratorEntries;
    [Metadata("The template is used to pre-define the collaborators that will be attached to the object.", "CollaboratorTemplate", false, false, false, "NamedObjectRef", 16778076, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Environment_CollaboratorTemplate")]
    protected Environment _CollaboratorTemplate;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Environment_EMailMessageToCollaborator")]
    [Metadata("EMail with details to be used in sending email.", "EMailMessage", false, false, false, "NamedObjectRef", 16778084, false, false, true, null)]
    protected Environment _EMailMessageToCollaborator;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Environment_CollaboratorData")]
    [Metadata("Collaborator data contains list of Collaborator Entries and email messages. Could be assigned to a Tracking Object", "CollaboratorData", false, false, false, "SubentityRef", 16778086, false, false, false, null)]
    protected Environment _CollaboratorData;
    [Metadata("EMail with details to be used in sending email.", "EMailMessage", false, false, false, "NamedObjectRef", 16778085, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Environment_EMailMessageToOwner")]
    protected Environment _EMailMessageToOwner;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Environment_NotifyCollaborators")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778092, false, false, false, "0")]
    protected Environment _NotifyCollaborators;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Environment_CurrentSheetLevel")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778904, false, false, false, null)]
    protected Environment _CurrentSheetLevel;

    public Environment GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public CollaboratorEntryDetails_Environment CollaboratorEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorEntries), (object) value);
      }
      get
      {
        return (CollaboratorEntryDetails_Environment) this.PropertyGet(nameof (CollaboratorEntries));
      }
    }

    public Environment CollaboratorTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CollaboratorTemplate));
      }
    }

    public Environment EMailMessageToCollaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessageToCollaborator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EMailMessageToCollaborator));
      }
    }

    public Environment CollaboratorData
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CollaboratorData));
      }
    }

    public Environment EMailMessageToOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessageToOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EMailMessageToOwner));
      }
    }

    public Environment NotifyCollaborators
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyCollaborators), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NotifyCollaborators));
      }
    }

    public Environment CurrentSheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSheetLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentSheetLevel));
      }
    }
  }
}
