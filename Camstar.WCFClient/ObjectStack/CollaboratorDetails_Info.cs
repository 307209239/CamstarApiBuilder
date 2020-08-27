// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorDetails_Info
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
  public class CollaboratorDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Info_GeneralInstructions")]
    protected Info _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Info_CollaboratorEntries")]
    protected CollaboratorEntryDetails_Info _CollaboratorEntries;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Info_CollaboratorTemplate")]
    protected Info _CollaboratorTemplate;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Info_EMailMessageToCollaborator")]
    protected Info _EMailMessageToCollaborator;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Info_CollaboratorData")]
    protected Info _CollaboratorData;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Info_EMailMessageToOwner")]
    protected Info _EMailMessageToOwner;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Info_NotifyCollaborators")]
    protected Info _NotifyCollaborators;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorDetails_Info_CurrentSheetLevel")]
    protected Info _CurrentSheetLevel;

    public Info GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public CollaboratorEntryDetails_Info CollaboratorEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorEntries), (object) value);
      }
      get
      {
        return (CollaboratorEntryDetails_Info) this.PropertyGet(nameof (CollaboratorEntries));
      }
    }

    public Info CollaboratorTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollaboratorTemplate));
      }
    }

    public Info EMailMessageToCollaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessageToCollaborator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EMailMessageToCollaborator));
      }
    }

    public Info CollaboratorData
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollaboratorData));
      }
    }

    public Info EMailMessageToOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessageToOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EMailMessageToOwner));
      }
    }

    public Info NotifyCollaborators
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyCollaborators), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NotifyCollaborators));
      }
    }

    public Info CurrentSheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSheetLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentSheetLevel));
      }
    }
  }
}
