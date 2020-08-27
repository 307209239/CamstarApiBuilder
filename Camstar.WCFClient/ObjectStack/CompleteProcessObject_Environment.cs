// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteProcessObject_Environment
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
  public class CompleteProcessObject_Environment : ProcessObjectTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObject_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected new Environment _Comments;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObject_Environment_DueDate")]
    protected Environment _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObject_Environment_CompletionComments")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _CompletionComments;

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueDate));
      }
    }

    public Environment CompletionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionComments));
      }
    }
  }
}
