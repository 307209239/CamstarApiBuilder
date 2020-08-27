// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SPCChartDefMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SPCChartDefMaintService : NamedDataObjectMaintBase
  {
    public SPCChartDefMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISPCChartDefMaintService), userProfile);
    }

    public ResultStatus Delete(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefMaintService) this._Channel).Delete(this._UserProfile, sPCChartDefMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefMaintMethod(sPCChartDefMaint, SPCChartDefMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SPCChartDefMaint) null, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus Delete(SPCChartDefMaint sPCChartDefMaint)
    {
      return this.Delete(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus Delete(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      return this.Delete(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefMaintService) this._Channel).Freeze(this._UserProfile, sPCChartDefMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefMaintMethod(sPCChartDefMaint, SPCChartDefMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SPCChartDefMaint) null, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus Freeze(SPCChartDefMaint sPCChartDefMaint)
    {
      return this.Freeze(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus Freeze(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      return this.Freeze(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefMaintService) this._Channel).GetWIPMsgs(this._UserProfile, sPCChartDefMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefMaintMethod(sPCChartDefMaint, SPCChartDefMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SPCChartDefMaint) null, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SPCChartDefMaint sPCChartDefMaint)
    {
      return this.GetWIPMsgs(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      return this.GetWIPMsgs(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefMaintService) this._Channel).Load(this._UserProfile, sPCChartDefMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefMaintMethod(sPCChartDefMaint, SPCChartDefMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SPCChartDefMaint) null, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus Load(SPCChartDefMaint sPCChartDefMaint)
    {
      return this.Load(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus Load(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      return this.Load(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_LoadESigDetails_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefMaintService) this._Channel).LoadESigDetails(this._UserProfile, sPCChartDefMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefMaintMethod(sPCChartDefMaint, SPCChartDefMaintMethods.LoadESigDetails, (SPCChartDefMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SPCChartDefMaint) null, (SPCChartDefMaint_LoadESigDetails_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SPCChartDefMaint sPCChartDefMaint)
    {
      return this.LoadESigDetails(sPCChartDefMaint, (SPCChartDefMaint_LoadESigDetails_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      return this.LoadESigDetails(sPCChartDefMaint, (SPCChartDefMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefMaintService) this._Channel).New(this._UserProfile, sPCChartDefMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefMaintMethod(sPCChartDefMaint, SPCChartDefMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SPCChartDefMaint) null, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus New(SPCChartDefMaint sPCChartDefMaint)
    {
      return this.New(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus New(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      return this.New(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefMaintService) this._Channel).NewCopy(this._UserProfile, sPCChartDefMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefMaintMethod(sPCChartDefMaint, SPCChartDefMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SPCChartDefMaint) null, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus NewCopy(SPCChartDefMaint sPCChartDefMaint)
    {
      return this.NewCopy(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus NewCopy(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      return this.NewCopy(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefMaintService) this._Channel).SaveAs(this._UserProfile, sPCChartDefMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefMaintMethod(sPCChartDefMaint, SPCChartDefMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SPCChartDefMaint) null, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus SaveAs(SPCChartDefMaint sPCChartDefMaint)
    {
      return this.SaveAs(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus SaveAs(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      return this.SaveAs(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Parameters parameters,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefMaintService) this._Channel).UnFreeze(this._UserProfile, sPCChartDefMaint, parameters, request, out result) : this.AddMethod((Method) new SPCChartDefMaintMethod(sPCChartDefMaint, SPCChartDefMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) sPCChartDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SPCChartDefMaint) null, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus UnFreeze(SPCChartDefMaint sPCChartDefMaint)
    {
      return this.UnFreeze(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SPCChartDefMaint sPCChartDefMaint,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      return this.UnFreeze(sPCChartDefMaint, (SPCChartDefMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject sPCChartDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SPCChartDefMaint) sPCChartDefMaint, (SPCChartDefMaint_Parameters) parameters, (SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject sPCChartDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SPCChartDefMaint) sPCChartDefMaint, (SPCChartDefMaint_Parameters) parameters, (SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject sPCChartDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SPCChartDefMaint) sPCChartDefMaint, (SPCChartDefMaint_LoadESigDetails_Parameters) parameters, (SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject sPCChartDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefMaint_Result result1;
        ResultStatus resultStatus = this.New((SPCChartDefMaint) sPCChartDefMaint, (SPCChartDefMaint_Parameters) parameters, (SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject sPCChartDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SPCChartDefMaint) sPCChartDefMaint, (SPCChartDefMaint_Parameters) parameters, (SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject sPCChartDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SPCChartDefMaint) sPCChartDefMaint, (SPCChartDefMaint_Parameters) parameters, (SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject sPCChartDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SPCChartDefMaint) sPCChartDefMaint, (SPCChartDefMaint_Parameters) parameters, (SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject sPCChartDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefMaint_Result result1;
        ResultStatus resultStatus = this.Load((SPCChartDefMaint) sPCChartDefMaint, (SPCChartDefMaint_Parameters) parameters, (SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject sPCChartDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SPCChartDefMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SPCChartDefMaint) sPCChartDefMaint, (SPCChartDefMaint_Parameters) parameters, (SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      try
      {
        SPCChartDefMaintMethod[] methods = new SPCChartDefMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISPCChartDefMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SPCChartDefMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SPCChartDefMaint cdo,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      try
      {
        return ((ISPCChartDefMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SPCChartDefMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SPCChartDefMaint) cdo, (SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      return this.GetEnvironment((SPCChartDefMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SPCChartDefMaint cdo,
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      result = (SPCChartDefMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISPCChartDefMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SPCChartDefMaintMethod(cdo, SPCChartDefMaintMethods.ExecuteTransaction, (SPCChartDefMaint_Parameters) null));
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
        SPCChartDefMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SPCChartDefMaint) cdo, (SPCChartDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SPCChartDefMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SPCChartDefMaint_Request) null, out SPCChartDefMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SPCChartDefMaint_Request request,
      out SPCChartDefMaint_Result result)
    {
      return this.ExecuteTransaction((SPCChartDefMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SPCChartDefMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SPCChartDefMaintMethod(cdo, SPCChartDefMaintMethods.AddDataTransaction, (SPCChartDefMaint_Parameters) null));
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
        return this.AddDataTransaction((SPCChartDefMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
