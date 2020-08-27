// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ServerTraceItem
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ServerTraceItem
  {
    [DataMember(EmitDefaultValue = false, Name = "Name")]
    public string Name { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Value")]
    public string Value { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Attributes")]
    public TraceItemAttribute[] Attributes { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Parameters")]
    public TraceItemParameter[] Parameters { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Children")]
    public ServerTraceItem[] Children { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Started")]
    public DateTime Started { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Ended")]
    public DateTime Ended { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "StartedMemoryUsage")]
    public int StartedMemoryUsage { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "EndedMemoryUsage")]
    public int EndedMemoryUsage { get; set; }

    public string ElapsedTime
    {
      get
      {
        return this.Started.Ticks != 0L ? (this.Ended - this.Started).ToString() : (string) null;
      }
    }

    public string MemoryUsage
    {
      get
      {
        return this.StartedMemoryUsage != 0 ? (this.EndedMemoryUsage - this.StartedMemoryUsage).ToString() : (string) null;
      }
    }

    public string AttributesValue
    {
      get
      {
        return this.Attributes == null || this.Attributes.Length == 0 ? (string) null : ((IEnumerable<TraceItemAttribute>) this.Attributes).Select<TraceItemAttribute, string>((Func<TraceItemAttribute, string>) (a => " " + a.Name + "='" + a.Value + "'")).Aggregate<string>((Func<string, string, string>) ((s1, s2) => s1 + s2));
      }
    }

    public string DisplayName
    {
      get
      {
        string str = this.Name;
        string name = this.Name;
        if (!(name == "__cdoPerform"))
        {
          if (!(name == "if"))
          {
            if (!(name == "OnGetValue"))
            {
              if (name == "Initialize")
                str = "Init " + (((IEnumerable<TraceItemAttribute>) this.Attributes).FirstOrDefault<TraceItemAttribute>((Func<TraceItemAttribute, bool>) (a => a.Name == "__cdoName")) ?? new TraceItemAttribute()).Value + "." + (((IEnumerable<TraceItemAttribute>) this.Attributes).FirstOrDefault<TraceItemAttribute>((Func<TraceItemAttribute, bool>) (a => a.Name == "__fieldName")) ?? new TraceItemAttribute()).Value;
            }
            else
              str = "Get " + (((IEnumerable<TraceItemAttribute>) this.Attributes).FirstOrDefault<TraceItemAttribute>((Func<TraceItemAttribute, bool>) (a => a.Name == "__cdoName")) ?? new TraceItemAttribute()).Value + "." + (((IEnumerable<TraceItemAttribute>) this.Attributes).FirstOrDefault<TraceItemAttribute>((Func<TraceItemAttribute, bool>) (a => a.Name == "__fieldName")) ?? new TraceItemAttribute()).Value;
          }
          else
            str = "If " + (((IEnumerable<TraceItemParameter>) this.Parameters).FirstOrDefault<TraceItemParameter>((Func<TraceItemParameter, bool>) (a => a.Name == "Condition")) ?? new TraceItemParameter()).Expression;
        }
        else
          str = "Perform " + (((IEnumerable<TraceItemAttribute>) this.Attributes).FirstOrDefault<TraceItemAttribute>((Func<TraceItemAttribute, bool>) (a => a.Name == "__cdoName")) ?? new TraceItemAttribute()).Value + "." + (((IEnumerable<TraceItemAttribute>) this.Attributes).FirstOrDefault<TraceItemAttribute>((Func<TraceItemAttribute, bool>) (a => a.Name == "__method")) ?? new TraceItemAttribute()).Value;
        if (((IEnumerable<TraceItemParameter>) this.Parameters).FirstOrDefault<TraceItemParameter>((Func<TraceItemParameter, bool>) (p => p.Value != null)) != null)
          str = str + " [" + ((IEnumerable<TraceItemParameter>) this.Parameters).FirstOrDefault<TraceItemParameter>((Func<TraceItemParameter, bool>) (p => p.Value != null)).Value + "]";
        return str;
      }
    }

    public override string ToString()
    {
      return "<" + this.Name + this.AttributesValue + (this.Children == null || this.Children.Length == 0 ? " >\n" + this.Value : " >\n" + ((IEnumerable<ServerTraceItem>) this.Children).Select<ServerTraceItem, string>((Func<ServerTraceItem, string>) (c => c.ToString())).Aggregate<string>((Func<string, string, string>) ((s1, s2) => s1 + s2))) + "</" + this.Name + ">\n";
    }
  }
}
