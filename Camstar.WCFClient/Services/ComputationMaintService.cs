// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ComputationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ComputationMaintService : NamedDataObjectMaintBase
  {
    public ComputationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IComputationMaintService), userProfile);
    }

    public ResultStatus Delete(
      ComputationMaint computationMaint,
      ComputationMaint_Parameters parameters,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) computationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComputationMaintService) this._Channel).Delete(this._UserProfile, computationMaint, parameters, request, out result) : this.AddMethod((Method) new ComputationMaintMethod(computationMaint, ComputationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) computationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ComputationMaint) null, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus Delete(ComputationMaint computationMaint)
    {
      return this.Delete(computationMaint, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus Delete(
      ComputationMaint computationMaint,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      return this.Delete(computationMaint, (ComputationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ComputationMaint computationMaint,
      ComputationMaint_Parameters parameters,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) computationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComputationMaintService) this._Channel).Freeze(this._UserProfile, computationMaint, parameters, request, out result) : this.AddMethod((Method) new ComputationMaintMethod(computationMaint, ComputationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) computationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ComputationMaint) null, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus Freeze(ComputationMaint computationMaint)
    {
      return this.Freeze(computationMaint, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus Freeze(
      ComputationMaint computationMaint,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      return this.Freeze(computationMaint, (ComputationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ComputationMaint computationMaint,
      ComputationMaint_Parameters parameters,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) computationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComputationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, computationMaint, parameters, request, out result) : this.AddMethod((Method) new ComputationMaintMethod(computationMaint, ComputationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) computationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ComputationMaint) null, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ComputationMaint computationMaint)
    {
      return this.GetWIPMsgs(computationMaint, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ComputationMaint computationMaint,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      return this.GetWIPMsgs(computationMaint, (ComputationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ComputationMaint computationMaint,
      ComputationMaint_Parameters parameters,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) computationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComputationMaintService) this._Channel).Load(this._UserProfile, computationMaint, parameters, request, out result) : this.AddMethod((Method) new ComputationMaintMethod(computationMaint, ComputationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) computationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ComputationMaint) null, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus Load(ComputationMaint computationMaint)
    {
      return this.Load(computationMaint, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus Load(
      ComputationMaint computationMaint,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      return this.Load(computationMaint, (ComputationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ComputationMaint computationMaint,
      ComputationMaint_LoadESigDetails_Parameters parameters,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) computationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComputationMaintService) this._Channel).LoadESigDetails(this._UserProfile, computationMaint, parameters, request, out result) : this.AddMethod((Method) new ComputationMaintMethod(computationMaint, ComputationMaintMethods.LoadESigDetails, (ComputationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) computationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ComputationMaint) null, (ComputationMaint_LoadESigDetails_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ComputationMaint computationMaint)
    {
      return this.LoadESigDetails(computationMaint, (ComputationMaint_LoadESigDetails_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ComputationMaint computationMaint,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      return this.LoadESigDetails(computationMaint, (ComputationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ComputationMaint computationMaint,
      ComputationMaint_Parameters parameters,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) computationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComputationMaintService) this._Channel).New(this._UserProfile, computationMaint, parameters, request, out result) : this.AddMethod((Method) new ComputationMaintMethod(computationMaint, ComputationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) computationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ComputationMaint) null, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus New(ComputationMaint computationMaint)
    {
      return this.New(computationMaint, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus New(
      ComputationMaint computationMaint,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      return this.New(computationMaint, (ComputationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ComputationMaint computationMaint,
      ComputationMaint_Parameters parameters,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) computationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComputationMaintService) this._Channel).NewCopy(this._UserProfile, computationMaint, parameters, request, out result) : this.AddMethod((Method) new ComputationMaintMethod(computationMaint, ComputationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) computationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ComputationMaint) null, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus NewCopy(ComputationMaint computationMaint)
    {
      return this.NewCopy(computationMaint, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus NewCopy(
      ComputationMaint computationMaint,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      return this.NewCopy(computationMaint, (ComputationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ComputationMaint computationMaint,
      ComputationMaint_Parameters parameters,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) computationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComputationMaintService) this._Channel).SaveAs(this._UserProfile, computationMaint, parameters, request, out result) : this.AddMethod((Method) new ComputationMaintMethod(computationMaint, ComputationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) computationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ComputationMaint) null, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus SaveAs(ComputationMaint computationMaint)
    {
      return this.SaveAs(computationMaint, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus SaveAs(
      ComputationMaint computationMaint,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      return this.SaveAs(computationMaint, (ComputationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ComputationMaint computationMaint,
      ComputationMaint_Parameters parameters,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) computationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComputationMaintService) this._Channel).UnFreeze(this._UserProfile, computationMaint, parameters, request, out result) : this.AddMethod((Method) new ComputationMaintMethod(computationMaint, ComputationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) computationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ComputationMaint) null, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus UnFreeze(ComputationMaint computationMaint)
    {
      return this.UnFreeze(computationMaint, (ComputationMaint_Parameters) null, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ComputationMaint computationMaint,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      return this.UnFreeze(computationMaint, (ComputationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject computationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComputationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ComputationMaint) computationMaint, (ComputationMaint_Parameters) parameters, (ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject computationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComputationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ComputationMaint) computationMaint, (ComputationMaint_Parameters) parameters, (ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject computationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComputationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ComputationMaint) computationMaint, (ComputationMaint_LoadESigDetails_Parameters) parameters, (ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject computationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComputationMaint_Result result1;
        ResultStatus resultStatus = this.New((ComputationMaint) computationMaint, (ComputationMaint_Parameters) parameters, (ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject computationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComputationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ComputationMaint) computationMaint, (ComputationMaint_Parameters) parameters, (ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject computationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComputationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ComputationMaint) computationMaint, (ComputationMaint_Parameters) parameters, (ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject computationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComputationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ComputationMaint) computationMaint, (ComputationMaint_Parameters) parameters, (ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject computationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComputationMaint_Result result1;
        ResultStatus resultStatus = this.Load((ComputationMaint) computationMaint, (ComputationMaint_Parameters) parameters, (ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject computationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComputationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ComputationMaint) computationMaint, (ComputationMaint_Parameters) parameters, (ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      try
      {
        ComputationMaintMethod[] methods = new ComputationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IComputationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ComputationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComputationMaint cdo,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      try
      {
        return ((IComputationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ComputationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ComputationMaint) cdo, (ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      return this.GetEnvironment((ComputationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ComputationMaint cdo,
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      result = (ComputationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComputationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ComputationMaintMethod(cdo, ComputationMaintMethods.ExecuteTransaction, (ComputationMaint_Parameters) null));
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
        ComputationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ComputationMaint) cdo, (ComputationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ComputationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ComputationMaint_Request) null, out ComputationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ComputationMaint_Request request,
      out ComputationMaint_Result result)
    {
      return this.ExecuteTransaction((ComputationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ComputationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ComputationMaintMethod(cdo, ComputationMaintMethods.AddDataTransaction, (ComputationMaint_Parameters) null));
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
        return this.AddDataTransaction((ComputationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
