// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExportService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ExportService : ExportImportTxnsBase
  {
    public ExportService(UserProfile userProfile)
    {
      this.Initialize(typeof (IExportService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      Export export,
      Export_Parameters parameters,
      Export_Request request,
      out Export_Result result)
    {
      result = (Export_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) export, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportService) this._Channel).GetWIPMsgs(this._UserProfile, export, parameters, request, out result) : this.AddMethod((Method) new ExportMethod(export, ExportMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) export, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Export) null, (Export_Parameters) null, (Export_Request) null, out Export_Result _);
    }

    public ResultStatus GetWIPMsgs(Export export)
    {
      return this.GetWIPMsgs(export, (Export_Parameters) null, (Export_Request) null, out Export_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Export export,
      Export_Request request,
      out Export_Result result)
    {
      return this.GetWIPMsgs(export, (Export_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Export export,
      Export_Parameters parameters,
      Export_Request request,
      out Export_Result result)
    {
      result = (Export_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) export, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportService) this._Channel).Load(this._UserProfile, export, parameters, request, out result) : this.AddMethod((Method) new ExportMethod(export, ExportMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) export, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Export) null, (Export_Parameters) null, (Export_Request) null, out Export_Result _);
    }

    public ResultStatus Load(Export export)
    {
      return this.Load(export, (Export_Parameters) null, (Export_Request) null, out Export_Result _);
    }

    public ResultStatus Load(
      Export export,
      Export_Request request,
      out Export_Result result)
    {
      return this.Load(export, (Export_Parameters) null, request, out result);
    }

    protected override ResultStatus OnLoad(
      DCObject export,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Export_Result result1;
        ResultStatus resultStatus = this.Load((Export) export, (Export_Parameters) parameters, (Export_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject export,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Export_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Export) export, (Export_Parameters) parameters, (Export_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Export_Request request,
      out Export_Result result)
    {
      result = (Export_Result) null;
      try
      {
        ExportMethod[] methods = new ExportMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IExportService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Export_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Export_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Export cdo,
      Export_Request request,
      out Export_Result result)
    {
      result = (Export_Result) null;
      try
      {
        return ((IExportService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Export_Result result1;
        ResultStatus environment = this.GetEnvironment((Export) cdo, (Export_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Export_Request request, out Export_Result result)
    {
      return this.GetEnvironment((Export) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Export cdo,
      Export_Request request,
      out Export_Result result)
    {
      result = (Export_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IExportService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ExportMethod(cdo, ExportMethods.ExecuteTransaction, (Export_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Export_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Export) cdo, (Export_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Export cdo)
    {
      return this.ExecuteTransaction(cdo, (Export_Request) null, out Export_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Export_Request request,
      out Export_Result result)
    {
      return this.ExecuteTransaction((Export) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Export cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ExportMethod(cdo, ExportMethods.AddDataTransaction, (Export_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((Export) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
