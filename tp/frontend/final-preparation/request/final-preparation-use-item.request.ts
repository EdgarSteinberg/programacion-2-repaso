import { ApiProperty } from "@nestjs/swagger";
import { IsString } from "class-validator";

export class FinalPreparationUseItemRequest {
  @ApiProperty()
  @IsString()
  itemId!: string;

  @ApiProperty()
  @IsString()
  targetHeroId!: string;
}