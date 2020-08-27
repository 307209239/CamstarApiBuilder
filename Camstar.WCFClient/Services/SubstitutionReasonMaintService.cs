// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SubstitutionReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SubstitutionReasonMaintService : UserCodeMaintBase
  {
    public SubstitutionReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISubstitutionReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Parameters parameters,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubstitutionReasonMaintService) this._Channel).Delete(this._UserProfile, substitutionReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SubstitutionReasonMaintMethod(substitutionReasonMaint, SubstitutionReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SubstitutionReasonMaint) null, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus Delete(SubstitutionReasonMaint substitutionReasonMaint)
    {
      return this.Delete(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus Delete(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      return this.Delete(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Parameters parameters,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubstitutionReasonMaintService) this._Channel).Freeze(this._UserProfile, substitutionReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SubstitutionReasonMaintMethod(substitutionReasonMaint, SubstitutionReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SubstitutionReasonMaint) null, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus Freeze(SubstitutionReasonMaint substitutionReasonMaint)
    {
      return this.Freeze(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      return this.Freeze(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Parameters parameters,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubstitutionReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, substitutionReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SubstitutionReasonMaintMethod(substitutionReasonMaint, SubstitutionReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SubstitutionReasonMaint) null, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SubstitutionReasonMaint substitutionReasonMaint)
    {
      return this.GetWIPMsgs(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      return this.GetWIPMsgs(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Parameters parameters,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubstitutionReasonMaintService) this._Channel).Load(this._UserProfile, substitutionReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SubstitutionReasonMaintMethod(substitutionReasonMaint, SubstitutionReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SubstitutionReasonMaint) null, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus Load(SubstitutionReasonMaint substitutionReasonMaint)
    {
      return this.Load(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus Load(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      return this.Load(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_LoadESigDetails_Parameters parameters,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubstitutionReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, substitutionReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SubstitutionReasonMaintMethod(substitutionReasonMaint, SubstitutionReasonMaintMethods.LoadESigDetails, (SubstitutionReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SubstitutionReasonMaint) null, (SubstitutionReasonMaint_LoadESigDetails_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SubstitutionReasonMaint substitutionReasonMaint)
    {
      return this.LoadESigDetails(substitutionReasonMaint, (SubstitutionReasonMaint_LoadESigDetails_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      return this.LoadESigDetails(substitutionReasonMaint, (SubstitutionReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Parameters parameters,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubstitutionReasonMaintService) this._Channel).New(this._UserProfile, substitutionReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SubstitutionReasonMaintMethod(substitutionReasonMaint, SubstitutionReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SubstitutionReasonMaint) null, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus New(SubstitutionReasonMaint substitutionReasonMaint)
    {
      return this.New(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus New(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      return this.New(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Parameters parameters,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubstitutionReasonMaintService) this._Channel).NewCopy(this._UserProfile, substitutionReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SubstitutionReasonMaintMethod(substitutionReasonMaint, SubstitutionReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SubstitutionReasonMaint) null, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus NewCopy(SubstitutionReasonMaint substitutionReasonMaint)
    {
      return this.NewCopy(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      return this.NewCopy(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Parameters parameters,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubstitutionReasonMaintService) this._Channel).SaveAs(this._UserProfile, substitutionReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SubstitutionReasonMaintMethod(substitutionReasonMaint, SubstitutionReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SubstitutionReasonMaint) null, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus SaveAs(SubstitutionReasonMaint substitutionReasonMaint)
    {
      return this.SaveAs(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      return this.SaveAs(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Parameters parameters,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubstitutionReasonMaintService) this._Channel).UnFreeze(this._UserProfile, substitutionReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SubstitutionReasonMaintMethod(substitutionReasonMaint, SubstitutionReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) substitutionReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SubstitutionReasonMaint) null, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(SubstitutionReasonMaint substitutionReasonMaint)
    {
      return this.UnFreeze(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SubstitutionReasonMaint substitutionReasonMaint,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      return this.UnFreeze(substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject substitutionReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubstitutionReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SubstitutionReasonMaint) substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) parameters, (SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject substitutionReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubstitutionReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SubstitutionReasonMaint) substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) parameters, (SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject substitutionReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubstitutionReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SubstitutionReasonMaint) substitutionReasonMaint, (SubstitutionReasonMaint_LoadESigDetails_Parameters) parameters, (SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject substitutionReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubstitutionReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((SubstitutionReasonMaint) substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) parameters, (SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject substitutionReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubstitutionReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SubstitutionReasonMaint) substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) parameters, (SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject substitutionReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubstitutionReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SubstitutionReasonMaint) substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) parameters, (SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject substitutionReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubstitutionReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SubstitutionReasonMaint) substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) parameters, (SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject substitutionReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubstitutionReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((SubstitutionReasonMaint) substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) parameters, (SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject substitutionReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubstitutionReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SubstitutionReasonMaint) substitutionReasonMaint, (SubstitutionReasonMaint_Parameters) parameters, (SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      try
      {
        SubstitutionReasonMaintMethod[] methods = new SubstitutionReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISubstitutionReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SubstitutionReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SubstitutionReasonMaint cdo,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      try
      {
        return ((ISubstitutionReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SubstitutionReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SubstitutionReasonMaint) cdo, (SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      return this.GetEnvironment((SubstitutionReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SubstitutionReasonMaint cdo,
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      result = (SubstitutionReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubstitutionReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SubstitutionReasonMaintMethod(cdo, SubstitutionReasonMaintMethods.ExecuteTransaction, (SubstitutionReasonMaint_Parameters) null));
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
        SubstitutionReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SubstitutionReasonMaint) cdo, (SubstitutionReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SubstitutionReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SubstitutionReasonMaint_Request) null, out SubstitutionReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SubstitutionReasonMaint_Request request,
      out SubstitutionReasonMaint_Result result)
    {
      return this.ExecuteTransaction((SubstitutionReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SubstitutionReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SubstitutionReasonMaintMethod(cdo, SubstitutionReasonMaintMethods.AddDataTransaction, (SubstitutionReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((SubstitutionReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
