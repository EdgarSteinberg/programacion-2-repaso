import { Body, Controller, Get, Post, Put } from '@nestjs/common';
import { ApiOperation, ApiTags } from '@nestjs/swagger';
import { FinalPreparationService } from './final-preparation.service';
import { FinalPreparationPurchaseRequest } from './request/final-preparation-purchase.request';
import { FinalPreparationCurrentApi, FinalPreparationFinalStageApi, FinalPreparationInventoryApi, FinalPreparationPowerUpsApi, FinalPreparationPurchasesApi, FinalPreparationRewardsApi, FinalPreparationStrategiesApi, FinalPreparationUseItemApi } from 'src/basic/model/game-api/final-contract.model';
import { ResponseObject } from 'src/basic/response-object.interface';
import { AbstractController } from 'src/basic/abstract.controller';
import { FinalPreparationUseItemRequest } from './request/final-preparation-use-item.request';
import { FinalPreparationCurrentRequest } from './request/final-preparation-current.request';

@ApiTags('final-preparation')
@Controller('final-stage/preparation')
export class FinalPreparationController extends AbstractController {

  constructor(private readonly finalpreparationService: FinalPreparationService) {
    super();
  }

  @Get('rewards')
  async getRewards(): Promise<ResponseObject<FinalPreparationRewardsApi>> {
    return this.createOkResponse(
      await this.finalpreparationService.getRewards(),
    );
  }

  @Get('inventory')
  async getInventory(): Promise<ResponseObject<FinalPreparationInventoryApi>> {
    return this.createOkResponse(
      await this.finalpreparationService.getInventory(),
    );
  }

  @Get('powerUps')
  async getPowerUps(): Promise<ResponseObject<FinalPreparationPowerUpsApi>> {
    return this.createOkResponse(
      await this.finalpreparationService.getPowerUps(),
    );
  }

  @Get('strategies')
  async getStrategies(): Promise<ResponseObject<FinalPreparationStrategiesApi>> {
    return this.createOkResponse(
      await this.finalpreparationService.getStrategies(),
    );
  }

  @Get('finalStage')
  async getFinalStage(): Promise<ResponseObject<FinalPreparationFinalStageApi>> {
    return this.createOkResponse(
      await this.finalpreparationService.getFinalStage(),
    );
  }

  @Post('purchases')
  @ApiOperation({
    summary: 'Purchase a Power-Up for the current final preparation.',
  })
  async postPurchases(
    @Body() request: FinalPreparationPurchaseRequest,
  ): Promise<ResponseObject<FinalPreparationPurchasesApi>> {
    return this.createOkResponse(
      await this.finalpreparationService.postPurchases(request),
    );
  }

  @Post('useItem')
  @ApiOperation({
    summary: 'Use a Power-Up on a Hero during final preparation.',
  })
  async postUseItem(
    @Body() request: FinalPreparationUseItemRequest,
  ): Promise<ResponseObject<FinalPreparationUseItemApi>> {
    return this.createOkResponse(
      await this.finalpreparationService.postUseItem(request),
    );
  }

  @Put('current')
  @ApiOperation({
    summary: 'Save the preparation for the current journey.',
  })
  async putCurrent(
    @Body() request: FinalPreparationCurrentRequest,
  ): Promise<ResponseObject<FinalPreparationCurrentApi>> {
    return this.createOkResponse(
      await this.finalpreparationService.savePreparation(request),
    );
  }
}
