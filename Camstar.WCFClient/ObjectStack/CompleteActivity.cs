// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivity
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
  public class CompleteActivity : ProcessObjectTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_ProcessObjectDetails")]
    protected Camstar.WCF.ObjectStack.Activity _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_CollectDataPoints")]
    protected CollectDataPoints _CollectDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_ExecuteChecklist")]
    protected ExecuteChecklist _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Activity")]
    protected NamedSubentityRef _Activity;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Submit")]
    protected Primitive<bool> _Submit;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_CompletionComments")]
    protected Primitive<string> _CompletionComments;

    public override bool Equals(object obj)
    {
      return obj is CompleteActivity && object.Equals((object) this._Comments, (object) ((CompleteActivity) obj)._Comments) && (object.Equals((object) this._ProcessObjectDetails, (object) ((CompleteActivity) obj)._ProcessObjectDetails) && object.Equals((object) this._CollectDataPoints, (object) ((CompleteActivity) obj)._CollectDataPoints)) && (object.Equals((object) this._ProcessObject, (object) ((CompleteActivity) obj)._ProcessObject) && object.Equals((object) this._ExecuteChecklist, (object) ((CompleteActivity) obj)._ExecuteChecklist) && (object.Equals((object) this._Activity, (object) ((CompleteActivity) obj)._Activity) && object.Equals((object) this._Submit, (object) ((CompleteActivity) obj)._Submit))) && object.Equals((object) this._CompletionComments, (object) ((CompleteActivity) obj)._CompletionComments) && base.Equals(obj);
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public Camstar.WCF.ObjectStack.Activity ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.Activity) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public CollectDataPoints CollectDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectDataPoints), (object) value);
      }
      get
      {
        return (CollectDataPoints) this.PropertyGet(nameof (CollectDataPoints));
      }
    }

    public new NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public ExecuteChecklist ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public NamedSubentityRef Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Activity));
      }
    }

    public Primitive<bool> Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Submit));
      }
    }

    public Primitive<string> CompletionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CompletionComments));
      }
    }
  }
}
