// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivity_Info
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
  public class CompleteActivity_Info : ProcessObjectTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Info_ProcessObjectDetails")]
    protected Activity_Info _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Info_CollectDataPoints")]
    protected CollectDataPoints_Info _CollectDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Info_ProcessObject")]
    protected new Info _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Info_ExecuteChecklist")]
    protected ExecuteChecklist_Info _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Info_Activity")]
    protected Info _Activity;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Info_Submit")]
    protected Info _Submit;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Info_CompletionComments")]
    protected Info _CompletionComments;

    public new Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Activity_Info ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (Activity_Info) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public CollectDataPoints_Info CollectDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectDataPoints), (object) value);
      }
      get
      {
        return (CollectDataPoints_Info) this.PropertyGet(nameof (CollectDataPoints));
      }
    }

    public new Info ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public ExecuteChecklist_Info ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Info) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public Info Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Activity));
      }
    }

    public Info Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Submit));
      }
    }

    public Info CompletionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionComments));
      }
    }
  }
}
