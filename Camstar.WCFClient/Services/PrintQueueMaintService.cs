// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrintQueueMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PrintQueueMaintService : NamedDataObjectMaintBase
  {
    public PrintQueueMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPrintQueueMaintService), userProfile);
    }

    public ResultStatus Delete(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) printQueueMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQueueMaintService) this._Channel).Delete(this._UserProfile, printQueueMaint, parameters, request, out result) : this.AddMethod((Method) new PrintQueueMaintMethod(printQueueMaint, PrintQueueMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) printQueueMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PrintQueueMaint) null, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus Delete(PrintQueueMaint printQueueMaint)
    {
      return this.Delete(printQueueMaint, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus Delete(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      return this.Delete(printQueueMaint, (PrintQueueMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) printQueueMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQueueMaintService) this._Channel).Freeze(this._UserProfile, printQueueMaint, parameters, request, out result) : this.AddMethod((Method) new PrintQueueMaintMethod(printQueueMaint, PrintQueueMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) printQueueMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PrintQueueMaint) null, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus Freeze(PrintQueueMaint printQueueMaint)
    {
      return this.Freeze(printQueueMaint, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus Freeze(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      return this.Freeze(printQueueMaint, (PrintQueueMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) printQueueMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQueueMaintService) this._Channel).GetWIPMsgs(this._UserProfile, printQueueMaint, parameters, request, out result) : this.AddMethod((Method) new PrintQueueMaintMethod(printQueueMaint, PrintQueueMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) printQueueMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PrintQueueMaint) null, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(PrintQueueMaint printQueueMaint)
    {
      return this.GetWIPMsgs(printQueueMaint, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      return this.GetWIPMsgs(printQueueMaint, (PrintQueueMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) printQueueMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQueueMaintService) this._Channel).Load(this._UserProfile, printQueueMaint, parameters, request, out result) : this.AddMethod((Method) new PrintQueueMaintMethod(printQueueMaint, PrintQueueMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) printQueueMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PrintQueueMaint) null, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus Load(PrintQueueMaint printQueueMaint)
    {
      return this.Load(printQueueMaint, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus Load(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      return this.Load(printQueueMaint, (PrintQueueMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_LoadESigDetails_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) printQueueMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQueueMaintService) this._Channel).LoadESigDetails(this._UserProfile, printQueueMaint, parameters, request, out result) : this.AddMethod((Method) new PrintQueueMaintMethod(printQueueMaint, PrintQueueMaintMethods.LoadESigDetails, (PrintQueueMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) printQueueMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PrintQueueMaint) null, (PrintQueueMaint_LoadESigDetails_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus LoadESigDetails(PrintQueueMaint printQueueMaint)
    {
      return this.LoadESigDetails(printQueueMaint, (PrintQueueMaint_LoadESigDetails_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      return this.LoadESigDetails(printQueueMaint, (PrintQueueMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) printQueueMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQueueMaintService) this._Channel).New(this._UserProfile, printQueueMaint, parameters, request, out result) : this.AddMethod((Method) new PrintQueueMaintMethod(printQueueMaint, PrintQueueMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) printQueueMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PrintQueueMaint) null, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus New(PrintQueueMaint printQueueMaint)
    {
      return this.New(printQueueMaint, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus New(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      return this.New(printQueueMaint, (PrintQueueMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) printQueueMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQueueMaintService) this._Channel).NewCopy(this._UserProfile, printQueueMaint, parameters, request, out result) : this.AddMethod((Method) new PrintQueueMaintMethod(printQueueMaint, PrintQueueMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) printQueueMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PrintQueueMaint) null, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus NewCopy(PrintQueueMaint printQueueMaint)
    {
      return this.NewCopy(printQueueMaint, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus NewCopy(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      return this.NewCopy(printQueueMaint, (PrintQueueMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) printQueueMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQueueMaintService) this._Channel).SaveAs(this._UserProfile, printQueueMaint, parameters, request, out result) : this.AddMethod((Method) new PrintQueueMaintMethod(printQueueMaint, PrintQueueMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) printQueueMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PrintQueueMaint) null, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus SaveAs(PrintQueueMaint printQueueMaint)
    {
      return this.SaveAs(printQueueMaint, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus SaveAs(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      return this.SaveAs(printQueueMaint, (PrintQueueMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Parameters parameters,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) printQueueMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQueueMaintService) this._Channel).UnFreeze(this._UserProfile, printQueueMaint, parameters, request, out result) : this.AddMethod((Method) new PrintQueueMaintMethod(printQueueMaint, PrintQueueMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) printQueueMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PrintQueueMaint) null, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus UnFreeze(PrintQueueMaint printQueueMaint)
    {
      return this.UnFreeze(printQueueMaint, (PrintQueueMaint_Parameters) null, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PrintQueueMaint printQueueMaint,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      return this.UnFreeze(printQueueMaint, (PrintQueueMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject printQueueMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQueueMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PrintQueueMaint) printQueueMaint, (PrintQueueMaint_Parameters) parameters, (PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject printQueueMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQueueMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PrintQueueMaint) printQueueMaint, (PrintQueueMaint_Parameters) parameters, (PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject printQueueMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQueueMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PrintQueueMaint) printQueueMaint, (PrintQueueMaint_LoadESigDetails_Parameters) parameters, (PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject printQueueMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQueueMaint_Result result1;
        ResultStatus resultStatus = this.New((PrintQueueMaint) printQueueMaint, (PrintQueueMaint_Parameters) parameters, (PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject printQueueMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQueueMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PrintQueueMaint) printQueueMaint, (PrintQueueMaint_Parameters) parameters, (PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject printQueueMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQueueMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PrintQueueMaint) printQueueMaint, (PrintQueueMaint_Parameters) parameters, (PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject printQueueMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQueueMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PrintQueueMaint) printQueueMaint, (PrintQueueMaint_Parameters) parameters, (PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject printQueueMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQueueMaint_Result result1;
        ResultStatus resultStatus = this.Load((PrintQueueMaint) printQueueMaint, (PrintQueueMaint_Parameters) parameters, (PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject printQueueMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQueueMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PrintQueueMaint) printQueueMaint, (PrintQueueMaint_Parameters) parameters, (PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      try
      {
        PrintQueueMaintMethod[] methods = new PrintQueueMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPrintQueueMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PrintQueueMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintQueueMaint cdo,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      try
      {
        return ((IPrintQueueMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PrintQueueMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PrintQueueMaint) cdo, (PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      return this.GetEnvironment((PrintQueueMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PrintQueueMaint cdo,
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      result = (PrintQueueMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQueueMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PrintQueueMaintMethod(cdo, PrintQueueMaintMethods.ExecuteTransaction, (PrintQueueMaint_Parameters) null));
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
        PrintQueueMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PrintQueueMaint) cdo, (PrintQueueMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PrintQueueMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PrintQueueMaint_Request) null, out PrintQueueMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PrintQueueMaint_Request request,
      out PrintQueueMaint_Result result)
    {
      return this.ExecuteTransaction((PrintQueueMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PrintQueueMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PrintQueueMaintMethod(cdo, PrintQueueMaintMethods.AddDataTransaction, (PrintQueueMaint_Parameters) null));
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
        return this.AddDataTransaction((PrintQueueMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
