// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.FTPTransportMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class FTPTransportMaintService : DataTransportMaintBase
  {
    public FTPTransportMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IFTPTransportMaintService), userProfile);
    }

    public ResultStatus Delete(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Parameters parameters,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFTPTransportMaintService) this._Channel).Delete(this._UserProfile, fTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new FTPTransportMaintMethod(fTPTransportMaint, FTPTransportMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((FTPTransportMaint) null, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus Delete(FTPTransportMaint fTPTransportMaint)
    {
      return this.Delete(fTPTransportMaint, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus Delete(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      return this.Delete(fTPTransportMaint, (FTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Parameters parameters,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFTPTransportMaintService) this._Channel).Freeze(this._UserProfile, fTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new FTPTransportMaintMethod(fTPTransportMaint, FTPTransportMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((FTPTransportMaint) null, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus Freeze(FTPTransportMaint fTPTransportMaint)
    {
      return this.Freeze(fTPTransportMaint, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus Freeze(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      return this.Freeze(fTPTransportMaint, (FTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Parameters parameters,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFTPTransportMaintService) this._Channel).GetWIPMsgs(this._UserProfile, fTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new FTPTransportMaintMethod(fTPTransportMaint, FTPTransportMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((FTPTransportMaint) null, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(FTPTransportMaint fTPTransportMaint)
    {
      return this.GetWIPMsgs(fTPTransportMaint, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      return this.GetWIPMsgs(fTPTransportMaint, (FTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Parameters parameters,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFTPTransportMaintService) this._Channel).Load(this._UserProfile, fTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new FTPTransportMaintMethod(fTPTransportMaint, FTPTransportMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((FTPTransportMaint) null, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus Load(FTPTransportMaint fTPTransportMaint)
    {
      return this.Load(fTPTransportMaint, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus Load(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      return this.Load(fTPTransportMaint, (FTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_LoadESigDetails_Parameters parameters,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFTPTransportMaintService) this._Channel).LoadESigDetails(this._UserProfile, fTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new FTPTransportMaintMethod(fTPTransportMaint, FTPTransportMaintMethods.LoadESigDetails, (FTPTransportMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((FTPTransportMaint) null, (FTPTransportMaint_LoadESigDetails_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus LoadESigDetails(FTPTransportMaint fTPTransportMaint)
    {
      return this.LoadESigDetails(fTPTransportMaint, (FTPTransportMaint_LoadESigDetails_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      return this.LoadESigDetails(fTPTransportMaint, (FTPTransportMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Parameters parameters,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFTPTransportMaintService) this._Channel).New(this._UserProfile, fTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new FTPTransportMaintMethod(fTPTransportMaint, FTPTransportMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((FTPTransportMaint) null, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus New(FTPTransportMaint fTPTransportMaint)
    {
      return this.New(fTPTransportMaint, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus New(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      return this.New(fTPTransportMaint, (FTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Parameters parameters,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFTPTransportMaintService) this._Channel).NewCopy(this._UserProfile, fTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new FTPTransportMaintMethod(fTPTransportMaint, FTPTransportMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((FTPTransportMaint) null, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus NewCopy(FTPTransportMaint fTPTransportMaint)
    {
      return this.NewCopy(fTPTransportMaint, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus NewCopy(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      return this.NewCopy(fTPTransportMaint, (FTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Parameters parameters,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFTPTransportMaintService) this._Channel).SaveAs(this._UserProfile, fTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new FTPTransportMaintMethod(fTPTransportMaint, FTPTransportMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((FTPTransportMaint) null, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus SaveAs(FTPTransportMaint fTPTransportMaint)
    {
      return this.SaveAs(fTPTransportMaint, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus SaveAs(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      return this.SaveAs(fTPTransportMaint, (FTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Parameters parameters,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFTPTransportMaintService) this._Channel).UnFreeze(this._UserProfile, fTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new FTPTransportMaintMethod(fTPTransportMaint, FTPTransportMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) fTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((FTPTransportMaint) null, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus UnFreeze(FTPTransportMaint fTPTransportMaint)
    {
      return this.UnFreeze(fTPTransportMaint, (FTPTransportMaint_Parameters) null, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus UnFreeze(
      FTPTransportMaint fTPTransportMaint,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      return this.UnFreeze(fTPTransportMaint, (FTPTransportMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject fTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.Delete((FTPTransportMaint) fTPTransportMaint, (FTPTransportMaint_Parameters) parameters, (FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject fTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((FTPTransportMaint) fTPTransportMaint, (FTPTransportMaint_Parameters) parameters, (FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject fTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((FTPTransportMaint) fTPTransportMaint, (FTPTransportMaint_LoadESigDetails_Parameters) parameters, (FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject fTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.New((FTPTransportMaint) fTPTransportMaint, (FTPTransportMaint_Parameters) parameters, (FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject fTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((FTPTransportMaint) fTPTransportMaint, (FTPTransportMaint_Parameters) parameters, (FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject fTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((FTPTransportMaint) fTPTransportMaint, (FTPTransportMaint_Parameters) parameters, (FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject fTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((FTPTransportMaint) fTPTransportMaint, (FTPTransportMaint_Parameters) parameters, (FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject fTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.Load((FTPTransportMaint) fTPTransportMaint, (FTPTransportMaint_Parameters) parameters, (FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject fTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FTPTransportMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((FTPTransportMaint) fTPTransportMaint, (FTPTransportMaint_Parameters) parameters, (FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      try
      {
        FTPTransportMaintMethod[] methods = new FTPTransportMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IFTPTransportMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        FTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FTPTransportMaint cdo,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      try
      {
        return ((IFTPTransportMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        FTPTransportMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((FTPTransportMaint) cdo, (FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      return this.GetEnvironment((FTPTransportMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      FTPTransportMaint cdo,
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      result = (FTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFTPTransportMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new FTPTransportMaintMethod(cdo, FTPTransportMaintMethods.ExecuteTransaction, (FTPTransportMaint_Parameters) null));
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
        FTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((FTPTransportMaint) cdo, (FTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(FTPTransportMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (FTPTransportMaint_Request) null, out FTPTransportMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      FTPTransportMaint_Request request,
      out FTPTransportMaint_Result result)
    {
      return this.ExecuteTransaction((FTPTransportMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(FTPTransportMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new FTPTransportMaintMethod(cdo, FTPTransportMaintMethods.AddDataTransaction, (FTPTransportMaint_Parameters) null));
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
        return this.AddDataTransaction((FTPTransportMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
