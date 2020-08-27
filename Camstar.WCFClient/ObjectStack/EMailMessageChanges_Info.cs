// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailMessageChanges_Info
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
  public class EMailMessageChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Info_Subject")]
    protected Info _Subject;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Info_Sender")]
    protected Info _Sender;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Info_Message")]
    protected Info _Message;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Info_MessageFormat")]
    protected Info _MessageFormat;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Info_SendEMailOnTxnFailure")]
    protected Info _SendEMailOnTxnFailure;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Info_Name")]
    protected new Info _Name;

    public Info Subject
    {
      [param: In] set
      {
        this.PropertySet(nameof (Subject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Subject));
      }
    }

    public Info Sender
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sender), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sender));
      }
    }

    public Info Message
    {
      [param: In] set
      {
        this.PropertySet(nameof (Message), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Message));
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

    public Info MessageFormat
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageFormat), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MessageFormat));
      }
    }

    public Info SendEMailOnTxnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (SendEMailOnTxnFailure), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SendEMailOnTxnFailure));
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
