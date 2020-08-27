// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CARSeverityMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CARSeverityMaintService : UserCodeMaintBase
  {
    public CARSeverityMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICARSeverityMaintService), userProfile);
    }

    public ResultStatus Delete(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICARSeverityMaintService) this._Channel).Delete(this._UserProfile, cARSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new CARSeverityMaintMethod(cARSeverityMaint, CARSeverityMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((CARSeverityMaint) null, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus Delete(CARSeverityMaint cARSeverityMaint)
    {
      return this.Delete(cARSeverityMaint, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus Delete(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      return this.Delete(cARSeverityMaint, (CARSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICARSeverityMaintService) this._Channel).Freeze(this._UserProfile, cARSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new CARSeverityMaintMethod(cARSeverityMaint, CARSeverityMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((CARSeverityMaint) null, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus Freeze(CARSeverityMaint cARSeverityMaint)
    {
      return this.Freeze(cARSeverityMaint, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus Freeze(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      return this.Freeze(cARSeverityMaint, (CARSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICARSeverityMaintService) this._Channel).GetWIPMsgs(this._UserProfile, cARSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new CARSeverityMaintMethod(cARSeverityMaint, CARSeverityMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CARSeverityMaint) null, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(CARSeverityMaint cARSeverityMaint)
    {
      return this.GetWIPMsgs(cARSeverityMaint, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      return this.GetWIPMsgs(cARSeverityMaint, (CARSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICARSeverityMaintService) this._Channel).Load(this._UserProfile, cARSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new CARSeverityMaintMethod(cARSeverityMaint, CARSeverityMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CARSeverityMaint) null, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus Load(CARSeverityMaint cARSeverityMaint)
    {
      return this.Load(cARSeverityMaint, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus Load(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      return this.Load(cARSeverityMaint, (CARSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_LoadESigDetails_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICARSeverityMaintService) this._Channel).LoadESigDetails(this._UserProfile, cARSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new CARSeverityMaintMethod(cARSeverityMaint, CARSeverityMaintMethods.LoadESigDetails, (CARSeverityMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CARSeverityMaint) null, (CARSeverityMaint_LoadESigDetails_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus LoadESigDetails(CARSeverityMaint cARSeverityMaint)
    {
      return this.LoadESigDetails(cARSeverityMaint, (CARSeverityMaint_LoadESigDetails_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      return this.LoadESigDetails(cARSeverityMaint, (CARSeverityMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICARSeverityMaintService) this._Channel).New(this._UserProfile, cARSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new CARSeverityMaintMethod(cARSeverityMaint, CARSeverityMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((CARSeverityMaint) null, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus New(CARSeverityMaint cARSeverityMaint)
    {
      return this.New(cARSeverityMaint, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus New(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      return this.New(cARSeverityMaint, (CARSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICARSeverityMaintService) this._Channel).NewCopy(this._UserProfile, cARSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new CARSeverityMaintMethod(cARSeverityMaint, CARSeverityMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((CARSeverityMaint) null, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus NewCopy(CARSeverityMaint cARSeverityMaint)
    {
      return this.NewCopy(cARSeverityMaint, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus NewCopy(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      return this.NewCopy(cARSeverityMaint, (CARSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICARSeverityMaintService) this._Channel).SaveAs(this._UserProfile, cARSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new CARSeverityMaintMethod(cARSeverityMaint, CARSeverityMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((CARSeverityMaint) null, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus SaveAs(CARSeverityMaint cARSeverityMaint)
    {
      return this.SaveAs(cARSeverityMaint, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus SaveAs(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      return this.SaveAs(cARSeverityMaint, (CARSeverityMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Parameters parameters,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICARSeverityMaintService) this._Channel).UnFreeze(this._UserProfile, cARSeverityMaint, parameters, request, out result) : this.AddMethod((Method) new CARSeverityMaintMethod(cARSeverityMaint, CARSeverityMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) cARSeverityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((CARSeverityMaint) null, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus UnFreeze(CARSeverityMaint cARSeverityMaint)
    {
      return this.UnFreeze(cARSeverityMaint, (CARSeverityMaint_Parameters) null, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CARSeverityMaint cARSeverityMaint,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      return this.UnFreeze(cARSeverityMaint, (CARSeverityMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject cARSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CARSeverityMaint_Result result1;
        ResultStatus resultStatus = this.Delete((CARSeverityMaint) cARSeverityMaint, (CARSeverityMaint_Parameters) parameters, (CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject cARSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CARSeverityMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((CARSeverityMaint) cARSeverityMaint, (CARSeverityMaint_Parameters) parameters, (CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject cARSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CARSeverityMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CARSeverityMaint) cARSeverityMaint, (CARSeverityMaint_LoadESigDetails_Parameters) parameters, (CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject cARSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CARSeverityMaint_Result result1;
        ResultStatus resultStatus = this.New((CARSeverityMaint) cARSeverityMaint, (CARSeverityMaint_Parameters) parameters, (CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject cARSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CARSeverityMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((CARSeverityMaint) cARSeverityMaint, (CARSeverityMaint_Parameters) parameters, (CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject cARSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CARSeverityMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((CARSeverityMaint) cARSeverityMaint, (CARSeverityMaint_Parameters) parameters, (CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject cARSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CARSeverityMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((CARSeverityMaint) cARSeverityMaint, (CARSeverityMaint_Parameters) parameters, (CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject cARSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CARSeverityMaint_Result result1;
        ResultStatus resultStatus = this.Load((CARSeverityMaint) cARSeverityMaint, (CARSeverityMaint_Parameters) parameters, (CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject cARSeverityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CARSeverityMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CARSeverityMaint) cARSeverityMaint, (CARSeverityMaint_Parameters) parameters, (CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      try
      {
        CARSeverityMaintMethod[] methods = new CARSeverityMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICARSeverityMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CARSeverityMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CARSeverityMaint cdo,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      try
      {
        return ((ICARSeverityMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CARSeverityMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((CARSeverityMaint) cdo, (CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      return this.GetEnvironment((CARSeverityMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CARSeverityMaint cdo,
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      result = (CARSeverityMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICARSeverityMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CARSeverityMaintMethod(cdo, CARSeverityMaintMethods.ExecuteTransaction, (CARSeverityMaint_Parameters) null));
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
        CARSeverityMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CARSeverityMaint) cdo, (CARSeverityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CARSeverityMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (CARSeverityMaint_Request) null, out CARSeverityMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CARSeverityMaint_Request request,
      out CARSeverityMaint_Result result)
    {
      return this.ExecuteTransaction((CARSeverityMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CARSeverityMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CARSeverityMaintMethod(cdo, CARSeverityMaintMethods.AddDataTransaction, (CARSeverityMaint_Parameters) null));
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
        return this.AddDataTransaction((CARSeverityMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
