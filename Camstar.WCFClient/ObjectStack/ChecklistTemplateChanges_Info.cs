﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistTemplateChanges_Info
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
  public class ChecklistTemplateChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Info_ChecklistInstructions")]
    protected Info _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Info_ChecklistEntries")]
    protected ChecklistEntryChanges_Info _ChecklistEntries;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Info_Name")]
    protected new Info _Name;

    public Info ChecklistInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistInstructions));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public ChecklistEntryChanges_Info ChecklistEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistEntries), (object) value);
      }
      get
      {
        return (ChecklistEntryChanges_Info) this.PropertyGet(nameof (ChecklistEntries));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
