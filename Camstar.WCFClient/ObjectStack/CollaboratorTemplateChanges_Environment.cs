// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorTemplateChanges_Environment
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
  public class CollaboratorTemplateChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateChanges_Environment_GeneralInstructions")]
    [Metadata("Instruction", "", false, false, false, "String", 16778079, false, false, false, null)]
    protected Environment _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateChanges_Environment_ObjectToChange")]
    [Metadata("The template is used to pre-define the collaborators that will be attached to the object.", "CollaboratorTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("An entry in an collaborator sheet specifies the details for a single collaborator.", "CollaboratorEntryChanges", false, false, false, "CollaboratorEntryChanges", 16778078, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateChanges_Environment_CollaboratorEntries")]
    protected CollaboratorEntryChanges_Environment _CollaboratorEntries;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 16778076, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateChanges_Environment_Name")]
    protected new Environment _Name;

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

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public CollaboratorEntryChanges_Environment CollaboratorEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorEntries), (object) value);
      }
      get
      {
        return (CollaboratorEntryChanges_Environment) this.PropertyGet(nameof (CollaboratorEntries));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
