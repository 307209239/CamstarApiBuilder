// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintQueueChanges_Environment
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
  public class PrintQueueChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Environment_PrintQueue")]
    [Metadata("File directory path", "", false, true, false, "String", 1050609, false, false, false, null)]
    protected Environment _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Environment_PrintFile")]
    [Metadata("File directory path", "", false, false, false, "String", 1050630, false, false, false, null)]
    protected Environment _PrintFile;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Environment_ObjectToChange")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Environment_EncodingType")]
    [Metadata("Encoding methods of characters:\r\n1: UTF-16 LE\r\n2: UTF-16 BE\r\n3: UTF-8\r\n4: ASCII", "EncodingTypeEnum", false, false, false, "Integer", 16777654, false, false, true, null)]
    protected Environment _EncodingType;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050631, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Environment_OutputToFile")]
    protected Environment _OutputToFile;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050607, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "PrintQueueChanges_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    protected new Environment _Description;

    public Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Environment PrintFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintFile), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintFile));
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

    public Environment EncodingType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EncodingType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EncodingType));
      }
    }

    public Environment OutputToFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (OutputToFile), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OutputToFile));
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

    public new Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }
  }
}
