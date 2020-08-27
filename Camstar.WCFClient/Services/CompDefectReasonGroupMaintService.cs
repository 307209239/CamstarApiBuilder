// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompDefectReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CompDefectReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public CompDefectReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICompDefectReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Parameters parameters,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompDefectReasonGroupMaintService) this._Channel).Delete(this._UserProfile, compDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CompDefectReasonGroupMaintMethod(compDefectReasonGroupMaint, CompDefectReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((CompDefectReasonGroupMaint) null, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint)
    {
      return this.Delete(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      return this.Delete(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Parameters parameters,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompDefectReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, compDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CompDefectReasonGroupMaintMethod(compDefectReasonGroupMaint, CompDefectReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((CompDefectReasonGroupMaint) null, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint)
    {
      return this.Freeze(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      return this.Freeze(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Parameters parameters,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompDefectReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, compDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CompDefectReasonGroupMaintMethod(compDefectReasonGroupMaint, CompDefectReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CompDefectReasonGroupMaint) null, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint)
    {
      return this.GetWIPMsgs(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Parameters parameters,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompDefectReasonGroupMaintService) this._Channel).Load(this._UserProfile, compDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CompDefectReasonGroupMaintMethod(compDefectReasonGroupMaint, CompDefectReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CompDefectReasonGroupMaint) null, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint)
    {
      return this.Load(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      return this.Load(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_LoadESigDetails_Parameters parameters,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompDefectReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, compDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CompDefectReasonGroupMaintMethod(compDefectReasonGroupMaint, CompDefectReasonGroupMaintMethods.LoadESigDetails, (CompDefectReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CompDefectReasonGroupMaint) null, (CompDefectReasonGroupMaint_LoadESigDetails_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint)
    {
      return this.LoadESigDetails(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_LoadESigDetails_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Parameters parameters,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompDefectReasonGroupMaintService) this._Channel).New(this._UserProfile, compDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CompDefectReasonGroupMaintMethod(compDefectReasonGroupMaint, CompDefectReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((CompDefectReasonGroupMaint) null, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint)
    {
      return this.New(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      return this.New(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Parameters parameters,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompDefectReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, compDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CompDefectReasonGroupMaintMethod(compDefectReasonGroupMaint, CompDefectReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((CompDefectReasonGroupMaint) null, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint)
    {
      return this.NewCopy(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      return this.NewCopy(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Parameters parameters,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompDefectReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, compDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CompDefectReasonGroupMaintMethod(compDefectReasonGroupMaint, CompDefectReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((CompDefectReasonGroupMaint) null, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint)
    {
      return this.SaveAs(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      return this.SaveAs(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Parameters parameters,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompDefectReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, compDefectReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CompDefectReasonGroupMaintMethod(compDefectReasonGroupMaint, CompDefectReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) compDefectReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((CompDefectReasonGroupMaint) null, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint)
    {
      return this.UnFreeze(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CompDefectReasonGroupMaint compDefectReasonGroupMaint,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      return this.UnFreeze(compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject compDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((CompDefectReasonGroupMaint) compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) parameters, (CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject compDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((CompDefectReasonGroupMaint) compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) parameters, (CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject compDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CompDefectReasonGroupMaint) compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_LoadESigDetails_Parameters) parameters, (CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject compDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((CompDefectReasonGroupMaint) compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) parameters, (CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject compDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((CompDefectReasonGroupMaint) compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) parameters, (CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject compDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((CompDefectReasonGroupMaint) compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) parameters, (CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject compDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((CompDefectReasonGroupMaint) compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) parameters, (CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject compDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((CompDefectReasonGroupMaint) compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) parameters, (CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject compDefectReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CompDefectReasonGroupMaint) compDefectReasonGroupMaint, (CompDefectReasonGroupMaint_Parameters) parameters, (CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      try
      {
        CompDefectReasonGroupMaintMethod[] methods = new CompDefectReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICompDefectReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompDefectReasonGroupMaint cdo,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      try
      {
        return ((ICompDefectReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((CompDefectReasonGroupMaint) cdo, (CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((CompDefectReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CompDefectReasonGroupMaint cdo,
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      result = (CompDefectReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompDefectReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CompDefectReasonGroupMaintMethod(cdo, CompDefectReasonGroupMaintMethods.ExecuteTransaction, (CompDefectReasonGroupMaint_Parameters) null));
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
        CompDefectReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CompDefectReasonGroupMaint) cdo, (CompDefectReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CompDefectReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (CompDefectReasonGroupMaint_Request) null, out CompDefectReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CompDefectReasonGroupMaint_Request request,
      out CompDefectReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((CompDefectReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CompDefectReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CompDefectReasonGroupMaintMethod(cdo, CompDefectReasonGroupMaintMethods.AddDataTransaction, (CompDefectReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((CompDefectReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
